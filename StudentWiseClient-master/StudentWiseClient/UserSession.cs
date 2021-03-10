using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net;

namespace StudentWiseApi
{
    /// <summary>
    /// Represents a session of an authenticated user.
    /// </summary>
    public class UserSession
    {
        internal readonly string token;
        public User Info { get; }

        internal UserSession(string authToken, ParsedJson info)
        {
            token = authToken;
            Info = new User(info);
        }
        
        /// <summary>
        ///  Update all information about the account.
        /// </summary>
        public void UpdateAll(string email, string first_name, string last_name, string password, string current_password)
        {
            InvokeUpdate(new
                {
                    email,
                    first_name,
                    last_name,
                    password,
                    current_password
                }
            );

            Info.Email = email;
            Info.FirstName = first_name;
            Info.LastName = last_name;
            Info.UpdatedAt = DateTime.Now;
        }

        /// <summary>
        /// Update the email associated with the account.
        /// </summary>
        public void UpdateEmail(string email, string current_password)
        {
            InvokeUpdate(new { email, current_password } );

            Info.Email = email;
            Info.UpdatedAt = DateTime.Now;
        }

        /// <summary>
        /// Update the password of the account.
        /// </summary>
        public void UpdatePassword(string password, string current_password)
        {
            InvokeUpdate(new { password, current_password } );            
            Info.UpdatedAt = DateTime.Now;
        }

        /// <summary>
        /// Update the name of the account owner.
        /// </summary>
        public void UpdateName(string first_name, string last_name, string current_password)
        {
            InvokeUpdate(new { first_name, last_name, current_password });

            Info.FirstName = first_name;
            Info.LastName = last_name;
            Info.UpdatedAt = DateTime.Now;
        }

        internal void InvokeUpdate(object data)
        {
            var response = Server.Send(
                Server.user_url,
                token,
                "PUT",
                new { user = data }
            );

            if (response.StatusCode != HttpStatusCode.NoContent)
                throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Invalidates this session.
        /// </summary>
        public void Logout()
        {
            var response = Server.Send(
                Server.user_logout_url,
                token,
                "DELETE",
                null
            );

            if (response.StatusCode != HttpStatusCode.NoContent)
                throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }
    }
}
