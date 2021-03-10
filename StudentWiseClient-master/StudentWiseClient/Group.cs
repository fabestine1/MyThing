using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace StudentWiseApi
{
    public class Group
    {
        public int Id { get; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string Rules { get; protected set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; protected set; }

        /// <summary>
        /// Open an exiting group by ID.
        /// </summary>
        public static Group Query(int group_id)
        {
            var response = Server.Send(
                string.Format(Server.group_manage_url, group_id),
                null,
                "GET",
                null
            );

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return new Group(ParsedJson.Parse(reader.ReadToEnd()));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Enumerates all groups.
        /// </summary>
        public static List<Group> Enumerate()
        {
            var response = Server.Send(
                Server.group_url,
                null,
                "GET",
                null
            );

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return ParsedJson.ParseArray(reader.ReadToEnd()).ConvertAll(g => new Group(g));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Create a new group.
        /// </summary>
        /// <remarks>This action requires administrative access.</remarks>
        public static Group Create(string name, string description, string rules, UserSession session = null)
        {
            return InvokeUpdate(-1, new { name, description, rules }, session);
        }

        /// <summary>
        /// Modify an existing group by ID
        /// </summary>
        /// <remarks>This action requires administrative access.</remarks>
        public static Group Modify(int group_id, string name, string description, string rules, UserSession session = null)
        {
            return InvokeUpdate(group_id, new { name, description, rules }, session);
        }

        /// <summary>
        /// Modify this group's name
        /// </summary>
        /// <remarks>This action requires administrative access.</remarks>
        public void UpdateName(string value, UserSession session = null)
        {
            if (Name != value)
            {
                UpdatedAt = InvokeUpdate(Id, new { name = value }, session).UpdatedAt;
                Name = value;
            }
        }

        /// <summary>
        /// Modify this group's description
        /// </summary>
        /// <remarks>This action requires administrative access.</remarks>
        public void UpdateDescription(string value, UserSession session = null)
        {
            if (Description != value)
            {
                UpdatedAt = InvokeUpdate(Id, new { description = value }, session).UpdatedAt;
                Description = value;
            }
        }

        /// <summary>
        /// Modify this group's rules
        /// </summary>
        /// <remarks>This action requires administrative access.</remarks>
        public void UpdateRules(string value, UserSession session = null)
        {
            if (Rules != value)
            {
                UpdatedAt = InvokeUpdate(Id, new { rules = value }, session).UpdatedAt;
                Rules = value;
            }
        }

        /// <summary>
        /// Delete a group by ID
        /// </summary>
        /// <remarks>This action requires administrative access.</remarks>
        public static void Delete(int group_id, UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            // Negarive IDs are reserved for group creation
            var response = Server.Send(
                string.Format(Server.group_manage_url, group_id),
                session.token,
                "DELETE",
                null
            );

            if (response.StatusCode != HttpStatusCode.NoContent)
                throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Delete this group.
        /// </summary>
        /// <remarks>This action requires administrative access.</remarks>
        public void Delete(UserSession session = null)
        {
            Delete(Id, session);
        }

        /// <summary>
        /// Add a member to a group by ID.
        /// </summary>
        /// <remarks>This action requires administrative access.</remarks>
        public static Group AddMember(int group_id, int user_id, UserSession session = null)
        {
            return ManageMembers(group_id, user_id, true, session);
        }

        /// <summary>
        /// Add a member to this group.
        /// </summary>
        /// <remarks>This action requires administrative access.</remarks>
        public Group AddMember(int user_id, UserSession session = null)
        {
            return ManageMembers(Id, user_id, true, session);
        }

        /// <summary>
        /// Removes a member from a group by ID.
        /// </summary>
        /// <remarks>This action requires administrative access.</remarks>
        public static Group RemoveMember(int group_id, int user_id, UserSession session = null)
        {
            return ManageMembers(group_id, user_id, false, session);
        }

        /// <summary>
        /// Removes a member from this group.
        /// </summary>
        /// <remarks>This action requires administrative access.</remarks>
        public Group RemoveMember(int user_id, UserSession session = null)
        {
            return ManageMembers(Id, user_id, false, session);
        }

        internal static Group ManageMembers(int group_id, int user_id, bool add, UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            // Negarive IDs are reserved for group creation
            var response = Server.Send(
                string.Format(Server.group_member_url, group_id),
                session.token,
                add ? "PUT": "DELETE",
                new
                {
                    group_member = new
                    {
                        member_id = user_id
                    }
                }
            );

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return new Group(ParsedJson.Parse(reader.ReadToEnd()).GetObject("user").GetObject("group"));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        internal static Group InvokeUpdate(int group_id, object body, UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            // Negarive IDs are reserved for group creation
            var response = Server.Send(
                group_id < 0 ?
                    Server.group_url :
                    string.Format(Server.group_manage_url, group_id),
                session.token,
                "POST",
                new
                {
                    group = body
                }
            );

            if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return new Group(ParsedJson.Parse(reader.ReadToEnd()));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        internal Group(ParsedJson info)
        {
            Id = info.GetInt("id");
            Name = info.GetString("name");
            Description = info.GetString("description");
            Rules = info.GetString("rules");
            CreatedAt = info.GetDateTime("created_at", false).Value;
            UpdatedAt = info.GetDateTime("updated_at", false).Value;
        }
    }
}
