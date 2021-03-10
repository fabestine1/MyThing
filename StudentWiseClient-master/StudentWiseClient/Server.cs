using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Net;
using System.Globalization;

namespace StudentWiseApi
{
    /// <summary>
    /// Represents a server that logs in users and creates new accounts.
    /// </summary>
    public class Server
    {
        protected const string base_url = "https://studentwise.herokuapp.com/api/v1";
        internal const string user_url = base_url + "/users";
        internal const string user_manage_url = base_url + "/users/{0}";
        internal const string user_login_url = base_url + "/users/login";
        internal const string user_logout_url = base_url + "/users/logout";
        internal const string group_url = base_url + "/groups";
        internal const string group_manage_url = base_url + "/groups/{0}";
        internal const string group_member_url = base_url + "/groups/{0}/members";
        internal const string event_url = base_url + "/events";
        internal const string event_manage_url = base_url + "/events/{0}";
        internal const string event_vote_url = base_url + "/events/{0}/votes";
        internal const string event_mark_url = base_url + "/events/{0}/mark_as_finished";
        internal const string event_unmark_url = base_url + "/events/{0}/unmark_as_finished";
        internal const string event_participant_url = base_url + "/events/{0}/participants";
        internal const string complaint_url = base_url + "/complaints";
        internal const string complaint_manage_url = base_url + "/complaints/{0}";
        internal const string complaint_mark_progress_url = base_url + "/complaints/{0}/mark_as_in_progress";
        internal const string complaint_mark_rejected_url = base_url + "/complaints/{0}/mark_as_rejected";
        internal const string complaint_mark_resolved_url = base_url + "/complaints/{0}/mark_as_resolved";
        internal const string expense_url = base_url + "/expenses";
        internal const string expense_manage_url = base_url + "/expenses/{0}";
        internal const string expense_participant_url = base_url + "/expenses/{0}/participants";
        internal const string expense_archive_url = base_url + "/expenses/{0}/archive";
        internal const string expense_unarchive_url = base_url + "/expenses/{0}/unarchive";
        internal const string agreement_url = base_url + "/agreements";
        internal const string agreement_manage_url = base_url + "/agreements/{0}";

        static internal HttpWebResponse Send(string url, string token, string method, object data, JsonSerializerOptions options = null)
        {
            WebRequest request = WebRequest.Create(url);

            request.Method = method;

            if (token != null)
                request.Headers.Add("authorization", token);

            if (data != null)
            {
                request.ContentType = "application/json";
                using (var stream = new StreamWriter(request.GetRequestStream()))
                    stream.Write(JsonSerializer.Serialize(data, options));
            }

            try
            {
                return (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                // WebRequest throws exceptions on unsuccessful codes.
                // Catch them and examine the response.

                throw CollectServerErrors(e);
            }
        }

        public static string UnexpectedStatus(HttpStatusCode status)
        {
            return $"Server returned unexpected status {(int)status} ({status})";
        }    
        
        internal static Exception CollectServerErrors(WebException e)
        {
            // We can't examine exceptions that are not related 
            // to server responses (timeouts, network failures, ...)
            if (!(e.Response is HttpWebResponse response))
                return e;

            if (response.ContentLength != 0)
            {
                try
                {
                    var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    var json = ParsedJson.Parse(reader.ReadToEnd());

                    if (json.Members.TryGetValue("error", out JsonElement error) ||
                        json.Members.TryGetValue("errors", out error))
                    {
                        // If the response is just a string then use it
                        if (error.ValueKind == JsonValueKind.String)
                            return new Exception(error.GetString(), e);
                        
                        // If we have key-value errors, then collect them
                        if (error.ValueKind == JsonValueKind.Object)
                        {
                            var messages = new List<string>();

                            json = ParsedJson.Parse(error.GetRawText());

                            foreach (var member in json.Members)
                            {
                                switch (member.Value.ValueKind)
                                {
                                    // Add strings
                                    case JsonValueKind.String:
                                        messages.Add($"{member.Key} {member.Value.GetString()}.");
                                        break;

                                    // Flatten arrays of strings
                                    case JsonValueKind.Array:
                                        foreach(var member_element in member.Value.EnumerateArray())
                                        {
                                            if (member_element.ValueKind == JsonValueKind.String)
                                                messages.Add($"{member.Key} {member_element.GetString()}.");
                                        }
                                        break;
                                }
                            }

                            if (messages.Count > 0)
                                return new Exception(string.Join(Environment.NewLine, messages), e);
                        }
                    }
                }
                catch
                {
                    // If we failed to parse the response, just ignore it
                    // and fall back to the default message.
                }
            }

            return e;
        }

        /// <summary>
        /// Methods that act on behalf of a user assume this session 
        /// if the caller does not specify a user session explicitly.
        /// </summary>
        static public UserSession CurrentSession { get; set; }

        static internal UserSession FallbackToCurrentSession
        {
            get
            {
                if (CurrentSession != null)
                    return CurrentSession;
                else
                    throw new ArgumentNullException("Current user session is not assigned.");
            } 
        }

        /// <summary>
        /// Authenticate the user on the server.
        /// </summary>
        /// <returns>A new user session.</returns>
        static public UserSession Login(string email, string password)
        {
            var response = Send(
                user_login_url,
                null,
                "POST",
                new
                {
                    user = new
                    {
                        email,
                        password
                    }
                }
            ) ;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                
                return new UserSession(
                    response.Headers.Get("authorization"),
                    ParsedJson.Parse(reader.ReadToEnd())
                );
            }

            throw new Exception(UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Create a new user account on the server.
        /// </summary>
        /// <returns>A new user session.</returns>
        static public UserSession CreateUser(string email, string first_name, string last_name, string password)
        {
            var response = Send(
                user_url,
                null,
                "POST",
                new
                {
                    user = new
                    {
                        email,
                        first_name,
                        last_name,
                        password
                    }
                }
            );

            if (response.StatusCode == HttpStatusCode.Created)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                
                return new UserSession(
                    response.Headers.Get("authorization"),
                    ParsedJson.Parse(reader.ReadToEnd())
                );
            }

            throw new Exception(UnexpectedStatus(response.StatusCode));
        }
    }
}
