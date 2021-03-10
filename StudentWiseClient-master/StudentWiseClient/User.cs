using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;

namespace StudentWiseApi
{
    /// <summary>
    /// Represents an account.
    /// </summary>
    public class User
    {
        public int Id { get; }
        public Group PrimaryGroup { get; internal set; }
        public string Email { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public DateTime CreatedAt { get; }
        public DateTime? UpdatedAt { get; internal set; }
        public bool Admin { get; }

        /// <summary>
        /// Query information about an account.
        /// </summary>
        public static User Query(int id, UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            var response = Server.Send(
                string.Format(Server.user_manage_url, id),
                session.token,
                "GET",
                null
            );

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return new User(ParsedJson.Parse(reader.ReadToEnd()));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Calculates user's balance based on existing expenses.
        /// </summary>
        /// <param name="expenses">
        /// To optimize balance calculation for multiple users, obtain a list of expenses first,
        /// and then pass it as this parameter for each of the users.
        /// </param>
        public decimal ComputeBalance(List<Expense> expenses = null, UserSession session = null)
        {
            decimal balance = 0;
            expenses = expenses ?? Expense.Enumerate(session);

            // Add expences that the user owns (payed)
            balance += expenses.Where(e => !e.Archived && e.Creator == this).ToList().
                ConvertAll(e => e.Price * e.Quantity).Append(0).Aggregate((a, b) => a + b);

            // Substract expences where the user participates (e.g. needs to pay)
            balance -= expenses.Where(e => !e.Archived && e.Participants.Contains(this)).ToList().
                ConvertAll(e => e.Price * e.Quantity / e.Participants.Count).Append(0).Aggregate((a, b) => a + b);

            return balance;
        }

        /// <summary>
        /// Enumerate user accounts.
        /// </summary>
        public static List<User> Enumerate(UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            var response = Server.Send(
                Server.user_url,
                session.token,
                "GET",
                null
            );

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return ParsedJson.ParseArray(reader.ReadToEnd()).ConvertAll(e => new User(e));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Moves this user to a specified group.
        /// </summary>
        /// <remarks>This action requires administrative access.</remarks>
        public void MoveToGroup(int group_id, UserSession session = null)
        {
            PrimaryGroup = Group.AddMember(group_id, Id, session);
            UpdatedAt = DateTime.Now;
        }
        
        public static bool operator ==(User a, User b)
        {
            if (ReferenceEquals(a, b))
                return true;

            if (a is null || b is null)
                return false;

            return a.Id == b.Id;
        }

        public static bool operator !=(User a, User b) => !(a == b);
        public override int GetHashCode() => Id;

        public override bool Equals(object obj)
        {
            if (obj as User == null)
                return false;

            return (User)obj == this;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        internal User(ParsedJson info)
        {
            Id = info.GetInt("id");

            // FIXED: when registering, the response contains a group_id instead of a group
            if (info.Members.ContainsKey("group_id"))
                PrimaryGroup = Group.Query(info.GetInt("group_id"));
            else
                PrimaryGroup = new Group(info.GetObject("group"));

            Email = info.GetString("email");
            FirstName = info.GetString("first_name");
            LastName = info.GetString("last_name");
            CreatedAt = info.GetDateTime("created_at", false).Value;
            UpdatedAt = info.GetDateTime("updated_at", true);
            Admin = info.GetBool("admin");
        }
    }
}
