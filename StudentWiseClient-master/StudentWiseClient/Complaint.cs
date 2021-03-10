using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Net;

namespace StudentWiseApi
{
    public enum ComplaintStatus
    {
        In_progress,
        Received,
        Rejected,
        Resolved,
        Sent
    }

    public class Complaint
    {
        public int Id { get; }
        public Group PrimaryGroup { get; }
        public string Title { get; protected set; }
        public string Description { get; protected set; }
        public User Creator { get; }
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; protected set; }
        public ComplaintStatus Status { get; protected set; }
        public bool Locked { get; protected set; }

        /// <summary>
        /// Create a new complaint.
        /// </summary>
        public static Complaint Create(string title, string description = null, UserSession session = null)
        {
            // Modifiying complaints with negative IDs is reserved for creating new ones.
            return InvokeUpdate(-1,
                new
                {
                    title,
                    description
                },
                session
            );
        }

        /// <summary>
        /// Enumerate existing complaints.
        /// </summary>
        public static List<Complaint> Enumerate(UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            var response = Server.Send(
                Server.complaint_url,
                session.token,
                "GET",
                null
            );

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return ParsedJson.ParseArray(reader.ReadToEnd()).ConvertAll(c => new Complaint(c));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// View an existing complaint by ID.
        /// </summary>
        public static Complaint Query(int complaint_id, UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            var response = Server.Send(
                string.Format(Server.complaint_manage_url, complaint_id),
                session.token,
                "GET",
                null
            );

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return new Complaint(ParsedJson.Parse(reader.ReadToEnd()));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Update information about a comlaint by ID.
        /// </summary>
        public static Complaint Modify(int complaint_id, string title, string description = null, UserSession session = null)
        {
            return InvokeUpdate(complaint_id,
                new
                {
                    title,
                    description
                },
                session
            );
        }
        
        /// <summary>
        /// Update a title of this complaint.
        /// </summary>
        public void UpdateTitle(string value, UserSession session = null)
        {
            if (value != Title)
            {
                UpdatedAt = InvokeUpdate(Id, new { title = value }, session).UpdatedAt;
                Title = value;
            }
        }

        /// <summary>
        /// Update a description of this complaint.
        /// </summary>
        public void UpdateDesctiption(string value, UserSession session = null)
        {
            if (value != Description)
            {
                UpdatedAt = InvokeUpdate(Id, new { description = value }, session).UpdatedAt;
                Description = value;
            }
        }

        /// <summary>
        /// Marks a complaint with the specified status
        /// </summary>
        /// <remarks>This action requires an administrative account.</remarks>
        /// <returns>New locked state of null otherwise.</returns>
        public static bool? MarkAs(int complaint_id, ComplaintStatus status, UserSession session = null)
        {
            string url;

            switch(status)
            {
                case ComplaintStatus.In_progress:
                    url = Server.complaint_mark_progress_url;
                    break;
                case ComplaintStatus.Rejected:
                    url = Server.complaint_mark_rejected_url;
                    break;
                case ComplaintStatus.Resolved:
                    url = Server.complaint_mark_resolved_url;
                    break;
                default:
                    throw new Exception("Invalid action: can't mark a complaint with this status");
            }

            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            var response = Server.Send(
                string.Format(url, complaint_id),
                session.token,
                "PUT",
                null
            );

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                var json = ParsedJson.Parse(reader.ReadToEnd());
                
                // Voting can cause status and lock change
                if (json.Members.ContainsKey("complaint"))
                {
                    json = json.GetObject("complaint");

                    if (json.Members.ContainsKey("locked"))
                        return json.GetBool("locked");
                }

                return null;
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Marks this complaint with a new status.
        /// </summary>
        /// <remarks>This action requires an administrative account.</remarks>
        public void MarkAs(ComplaintStatus status, UserSession session = null)
        {
            var newLocked = MarkAs(Id, status, session);

            if (newLocked.HasValue)
                Locked = newLocked.Value;

            Status = status;
            UpdatedAt = DateTime.Now;
        }

        /// <summary>
        /// Delete a complaint by ID.
        /// </summary>
        public static void Delete(int complaint_id, UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            // Negative complaint IDs are reserved for creating new complaints.
            var response = Server.Send(
                string.Format(Server.complaint_manage_url, complaint_id),
                session.token,
                "DELETE",
                null
            );
            
            if (response.StatusCode != HttpStatusCode.NoContent)
                throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Delete this complaint.
        /// </summary>
        public void Delete(UserSession session = null)
        {
            Delete(Id, session);
        }

        internal static Complaint InvokeUpdate(
            int complaint_id,
            object body,
            UserSession session = null
        )
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            // Negative complaint IDs are reserved for creating new complaints.
            var response = Server.Send(
                complaint_id < 0 ? Server.complaint_url : 
                    string.Format(Server.complaint_manage_url, complaint_id),
                session.token,
                complaint_id < 0 ? "POST" : "PUT",
                new
                {
                    complaint = body
                }
            );

            if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return new Complaint(ParsedJson.Parse(reader.ReadToEnd()));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        internal Complaint(ParsedJson json)
        {
            Id = json.GetInt("id");
            PrimaryGroup = new Group(json.GetObject("group"));
            Title = json.GetString("title");
            Description = json.GetString("description");
            CreatedAt = json.GetDateTime("created_at", false).Value;
            UpdatedAt = json.GetDateTime("updated_at", false).Value;
            Creator = new User(json.GetObject("creator"));
            Status = json.GetEnum<ComplaintStatus>("status");
        }
    }
}
