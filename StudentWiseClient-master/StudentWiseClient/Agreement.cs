using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace StudentWiseApi
{
    public class Agreement
    {
        public int Id { get; }
        public Group PrimaryGroup { get; }
        public string Title { get; protected set; }
        public string Description { get; protected set; }
        public User Creator { get; }
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; protected set; }

        /// <summary>
        /// Create a new agreement.
        /// </summary>
        public static Agreement Create(string title, string description = null, UserSession session = null)
        {
            // Modifiying agreements with negative IDs is reserved for creating new ones.
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
        /// Enumerate existing agreement.
        /// </summary>
        public static List<Agreement> Enumerate(UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            var response = Server.Send(
                Server.agreement_url,
                session.token,
                "GET",
                null
            );

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return ParsedJson.ParseArray(reader.ReadToEnd()).ConvertAll(a => new Agreement(a));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// View an existing agreement by ID.
        /// </summary>
        public static Agreement Query(int agreement_id, UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            var response = Server.Send(
                string.Format(Server.agreement_manage_url, agreement_id),
                session.token,
                "GET",
                null
            );

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return new Agreement(ParsedJson.Parse(reader.ReadToEnd()));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Update information about an agreement by ID.
        /// </summary>
        public static Agreement Modify(int agreement_id, string title, string description = null, UserSession session = null)
        {
            return InvokeUpdate(agreement_id,
                new
                {
                    title,
                    description
                },
                session
            );
        }

        /// <summary>
        /// Update a title of this agreement.
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
        /// Update a description of this agreement.
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
        /// Delete an agreement by ID.
        /// </summary>
        public static void Delete(int agreement_id, UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            // Negative agreement IDs are reserved for creating new agreements.
            var response = Server.Send(
                string.Format(Server.agreement_manage_url, agreement_id),
                session.token,
                "DELETE",
                null
            );

            if (response.StatusCode != HttpStatusCode.NoContent)
                throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Delete this agreement.
        /// </summary>
        public void Delete(UserSession session = null)
        {
            Delete(Id, session);
        }

        internal static Agreement InvokeUpdate(
            int agreement_id,
            object body,
            UserSession session = null
        )
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            // Negative agreement IDs are reserved for creating new agreements.
            var response = Server.Send(
                agreement_id < 0 ? Server.agreement_url:
                    string.Format(Server.agreement_manage_url, agreement_id),
                session.token,
                agreement_id < 0 ? "POST" : "PUT",
                new
                {
                    agreement = body
                }
            );

            if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return new Agreement(ParsedJson.Parse(reader.ReadToEnd()));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        internal Agreement(ParsedJson json)
        {
            Id = json.GetInt("id");
            PrimaryGroup = new Group(json.GetObject("group"));
            Title = json.GetString("title");
            Description = json.GetString("description");
            CreatedAt = json.GetDateTime("created_at", false).Value;
            UpdatedAt = json.GetDateTime("updated_at", false).Value;
            Creator = new User(json.GetObject("creator"));
        }
    }
}
