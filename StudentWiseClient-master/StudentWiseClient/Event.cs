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
    using EventKind = EventType;
    public enum EventType
    {
        Other,
        Duty,
        Party
    }

    public enum EventStatus
    {
        Finished,
        Marked_as_finished,
        Pending,
        Unfinished
    }

    public enum EventInvolvement
    {
        Creator,
        Participant,
        Voter
    }

    /// <summary>
    /// Represents a filter for event enumeration.
    /// </summary>
    public struct EventFilter
    {
        public EventInvolvement? InvolvedAs { get; set; }
        public EventKind? Kind { get; set; }
        [Obsolete("use Kind instead")]
        public EventKind? Type { get { return Kind; } set { Kind = value; } }
        public EventStatus? Status { get; set; }
        public bool? TimeConstrained{ get; set; }
        public DateTime? StartsBefore { get; set; }
        public DateTime? StartsAfter { get; set; }
        public DateTime? FinishesBefore { get; set; }
        public DateTime? FinishesAfter { get; set; }        

        public static EventFilter Today()
        {
            return new EventFilter()
            {
                TimeConstrained = true,
                StartsBefore = DateTime.Today.AddDays(1),
                FinishesAfter = DateTime.Today
            };
        }

        public static EventFilter Upcoming()
        {
            return new EventFilter()
            {
                TimeConstrained = true,
                StartsAfter = DateTime.Today.AddDays(1)
            };
        }

        public static EventFilter Involved(EventInvolvement involvement)
        {
            return new EventFilter()
            {
                InvolvedAs = involvement                
            };
        }

        public bool Matches(Event e, UserSession session = null)
        {
            // TODO: move the matching logic here
            return Event.Filter(new List<Event> { e }, this, session).Count > 0;
        }
    }
    
    /// <summary>
    /// Represents user's vote.
    /// </summary>
    public struct EventVote
    {
        public bool Finished { get; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        internal EventVote(ParsedJson json)
        {
            Finished = json.GetBool("finished");
            CreatedAt = json.GetDateTime("created_at", false).Value;
            UpdatedAt = json.GetDateTime("updated_at", false).Value;
        }
    }

    /// <summary>
    /// Represents an event organized by a user.
    /// </summary>
    public class Event
    {
        public int Id { get; }
        public Group PrimaryGroup { get; }
        public EventKind Kind { get; protected set; }
        [Obsolete("use Kind instead")]
        public EventKind Type { get; set; }
        public EventStatus Status { get; protected set; }
        public bool Locked { get; protected set; }
        public string Title { get; protected set; }
        public string Description { get; protected set; }
        public DateTime? StartsAt { get; protected set; }
        public DateTime? FinishesAt { get; protected set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; protected set; }
        public User Creator { get; }
        public List<User> Participants { get; }
        
        /// <summary>
        /// Each item in this list is a pair of a user ID and a vote itself.
        /// </summary>
        public Dictionary<int, EventVote> Votes { get; }

        /// <summary>
        /// Create a new event.
        /// </summary>
        public static Event Create(
            string title,
            string description = null,
            EventKind kind = EventKind.Other,
            DateTime? starts_at = null,
            DateTime? finishes_at = null,
            UserSession session = null
            )
        {
            // Updating events with negative IDs is reserved for creation of new ones
            return InvokeUpdate(-1,
                new
                {
                    title,
                    description,
                    kind = kind.ToString().ToLower(),
                    starts_at,
                    finishes_at
                },
                session
            );
        }

        /// <summary>
        /// Modify an existing event by ID.
        /// </summary>
        public static Event Modify(
            int event_id,
            string title,
            string description = null,
            EventKind kind = EventKind.Other,
            DateTime? starts_at = null,
            DateTime? finishes_at = null,
            UserSession session = null
            )
        {
            return InvokeUpdate(
                event_id,
                new
                {
                    title,
                    description,
                    kind = kind.ToString().ToLower(),
                    starts_at,
                    finishes_at
                },
                session
            );
        }

        /// <summary>
        /// Open an existing event by ID.
        /// </summary>
        public static Event Query(int event_id, UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            var response = Server.Send(
                string.Format(Server.event_manage_url, event_id),
                session.token,
                "GET",
                null
            );

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return new Event(ParsedJson.Parse(reader.ReadToEnd()));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Enumerate events in which you participate.
        /// </summary>
        public static List<Event> Enumerate(UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            var response = Server.Send(
                Server.event_url,
                session.token,
                "GET",
                null
            );

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return ParsedJson.ParseArray(reader.ReadToEnd()).ConvertAll(e => new Event(e));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        public static List<Event> Enumerate(EventFilter filter, UserSession session = null)
        {
            // TODO: switch to passing GET-parameters when the API is ready
            return Filter(Enumerate(session), filter, session);
        }

        public static List<Event> Filter(List<Event> events, EventFilter filter, UserSession session = null)
        {
            session = session ?? Server.CurrentSession;

            switch (filter.InvolvedAs)
            {
                case EventInvolvement.Creator:
                    events = events.Where(e => e.Creator == session.Info).ToList();
                    break;
                case EventInvolvement.Participant:
                    events = events.Where(e => e.Participants.Contains(session.Info)).ToList();
                    break;
                case EventInvolvement.Voter:
                    events = events.Where(e => e.Votes.ContainsKey(session.Info.Id)).ToList();
                    break;
            }

            if (filter.Kind.HasValue)
                events = events.Where(e => e.Kind == filter.Kind.Value).ToList();

            if (filter.Status.HasValue)
                events = events.Where(e => e.Status == filter.Status.Value).ToList();

            if (filter.TimeConstrained.HasValue)
                events = events.Where(e => filter.TimeConstrained.Value ^
                    (!e.StartsAt.HasValue && !e.FinishesAt.HasValue)).ToList();

            if (filter.StartsBefore.HasValue)
                events = events.Where(e => !e.StartsAt.HasValue || e.StartsAt <= filter.StartsBefore).ToList();

            if (filter.StartsAfter.HasValue)
                events = events.Where(e => !e.StartsAt.HasValue || e.StartsAt >= filter.StartsAfter).ToList();

            if (filter.FinishesBefore.HasValue)
                events = events.Where(e => !e.FinishesAt.HasValue || e.FinishesAt <= filter.FinishesBefore).ToList();

            if (filter.FinishesAfter.HasValue)
                events = events.Where(e => !e.FinishesAt.HasValue || e.FinishesAt >= filter.FinishesAfter).ToList();

            return events;
        }

        /// <summary>
        /// Delete an event by ID.
        /// </summary>
        public static void Delete(int event_id, UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            var response = Server.Send(
                string.Format(Server.event_manage_url, event_id),
                session.token,
                "DELETE",
                null
            );

            if (response.StatusCode != HttpStatusCode.NoContent)
                throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Delete this event.
        /// </summary>
        public void Delete(UserSession session = null)
        {
            Delete(Id, session);
        }

        /// <summary>
        /// Add a user as a participant of an event by ID.
        /// </summary>
        public static User AddParticipant(int event_id, int user_id, UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            var response = Server.Send(
                string.Format(Server.event_participant_url, event_id),
                session.token,
                "POST",
                new
                {
                    event_participant = new
                    {
                        participant_id = user_id
                    }
                }
            );
            
            if (response.StatusCode == HttpStatusCode.Created)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                var json = ParsedJson.Parse(reader.ReadToEnd());
                return new User(json.GetObject("participant"));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Add a user as a participant if this event.
        /// </summary>
        public void AddParticipant(int user_id, UserSession session = null)
        {
            Participants.Add(AddParticipant(Id, user_id, session));
            UpdatedAt = DateTime.Now;
        }

        /// <summary>
        /// Remove a participating user from an event by ID.
        /// </summary>
        public static void RemoveParticipant(int event_id, int user_id, UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            var response = Server.Send(
                string.Format(Server.event_participant_url, event_id),
                session.token,
                "DELETE",
                new
                {
                    event_participant = new
                    {
                        participant_id = user_id
                    }
                }
            );

            if (response.StatusCode != HttpStatusCode.NoContent)
                throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        /// <summary>
        /// Remove a participating user from this event.
        /// </summary>
        public void RemoveParticipant(int user_id, UserSession session = null)
        {
            RemoveParticipant(Id, user_id, session);
            Participants.Remove(Participants.Find(u => u.Id == user_id));
            UpdatedAt = DateTime.Now;
        }

        /// <summary>
        /// Vote for/against completion of this event.
        /// </summary>
        public void Vote(bool finished, UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            // See if there is a vote already
            var update_only = Votes.TryGetValue(session.Info.Id, out EventVote old_vote);

            if (update_only && finished == old_vote.Finished)
                return;
                        
            var response = Server.Send(
                string.Format(Server.event_vote_url, Id),
                session.token,
                update_only ? "PUT" : "POST",
                new
                {
                    event_vote = new
                    {
                        finished
                    }
                }
            );

            if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                var json = ParsedJson.Parse(reader.ReadToEnd());
                Votes[session.Info.Id] = new EventVote(json);
                UpdatedAt = DateTime.Now;

                // Voting can cause status and lock change
                if (json.Members.ContainsKey("event"))
                {
                    json = json.GetObject("event");

                    if (json.Members.ContainsKey("status"))
                        Status = json.GetEnum<EventStatus>("status");

                    if (json.Members.ContainsKey("locked"))
                        Locked = json.GetBool("locked");
                }
            }
               
            throw new Exception(Server.UnexpectedStatus(response.StatusCode));            
        }

        /// <summary>
        /// Revoke an existing vote.
        /// </summary>
        public void RevokeVote(UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            var response = Server.Send(
                string.Format(Server.event_vote_url, Id),
                session.token,
                "DELETE",
                null
            );

            if (response.StatusCode != HttpStatusCode.NoContent)
                throw new Exception(Server.UnexpectedStatus(response.StatusCode));

            Votes.Remove(session.Info.Id);
            UpdatedAt = DateTime.Now;
        }

        #region Propery updaters
        public void UpdateType(EventKind value, UserSession session = null)
        {
            if (value != Kind)
            {
                UpdatedAt = InvokeUpdate(Id, new { kind = value.ToString().ToLower() }, session).UpdatedAt;
                Kind = value;
            }
        }

        public void UpdateTitle(string value, UserSession session = null)
        {
            if (value != Title)
            {
                UpdatedAt = InvokeUpdate(Id, new { title = value }, session).UpdatedAt;
                Title = value;
            }
        }

        public void UpdateDescription(string value, UserSession session = null)
        {
            if (value != Description)
            {
                UpdatedAt = InvokeUpdate(Id, new { description = value }, session).UpdatedAt;
                Description = value;
            }

        }
        public void UpdateStartsAt(DateTime? value, UserSession session = null)
        {
            if (value != StartsAt)
            {
                UpdatedAt = InvokeUpdate(Id, new { starts_at = value }, session).UpdatedAt;
                StartsAt = value;
            }
        }
        public void UpdateFinishesAt(DateTime? value, UserSession session = null)
        {
            if (value != FinishesAt)
            {
                UpdatedAt = InvokeUpdate(Id, new { finishes_at = value }, session).UpdatedAt;
                FinishesAt = value;
            }
        }

        /// <summary>
        /// Marks an event as finished by ID.
        /// </summary>
        /// <returns>The new event status.</returns>
        public static EventStatus? MarkAsFinished(int event_id, UserSession session = null)
        {
            return MarkEvent(event_id, true, session);
        }

        /// <summary>
        /// Marks this event as finished.
        /// </summary>
        public void MarkAsFinished(UserSession session = null)
        {
            var newStatus = MarkAsFinished(Id, session);
            
            if (newStatus.HasValue)
                Status = newStatus.Value;

            UpdatedAt = DateTime.Now;
        }

        /// <summary>
        /// Unmarks an event as finished by ID.
        /// </summary>
        /// <returns>The new event status.</returns>
        public static EventStatus? MarkAsPending(int event_id, UserSession session = null)
        {
            return MarkEvent(event_id, false, session);
        }

        /// <summary>
        /// Unmarks this event as finished.
        /// </summary>
        public void MarkAsPending(UserSession session = null)
        {
            var newStatus = MarkAsPending(Id, session);

            if (newStatus.HasValue)
                Status = newStatus.Value;

            UpdatedAt = DateTime.Now;
        }
        #endregion

        internal static EventStatus? MarkEvent(int event_id, bool finished, UserSession session = null)
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            // Negative event IDs are reserved for creating new events.
            var response = Server.Send(
                finished ?
                    string.Format(Server.event_mark_url, event_id) :
                    string.Format(Server.event_unmark_url, event_id),
                session.token,
                "PUT",
                null
            );

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var data = new StreamReader(response.GetResponseStream(), Encoding.UTF8).ReadToEnd();

                if (data.Length > 0)
                {                    
                    var json = ParsedJson.Parse(data);

                    if (json.Members.ContainsKey("event"))
                    {
                        json = json.GetObject("event");

                        if (json.Members.ContainsKey("status"))
                            return json.GetEnum<EventStatus>("status");
                    }
                }
                
                return null;
            }
            
            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }

        internal Event(ParsedJson json)
        {
            Id = json.GetInt("id");
            PrimaryGroup = new Group(json.GetObject("group"));
            Description = json.GetString("description");
            Title = json.GetString("title");
            StartsAt = json.GetDateTime("starts_at", true);
            FinishesAt = json.GetDateTime("finishes_at", true);
            CreatedAt = json.GetDateTime("created_at", false).Value;
            UpdatedAt = json.GetDateTime("updated_at", false).Value;
            Creator = new User(json.GetObject("creator"));
            Kind = json.GetEnum<EventKind>("kind");
            Status = json.GetEnum<EventStatus>("status");
            Locked = json.GetBool("locked");
            Participants = json.GetArray("participants").ConvertAll(e => new User(e));            
            Votes = new Dictionary<int, EventVote>();

            foreach (var vote in json.GetArray("votes"))
            {
                Votes[vote.GetInt("id")] = new EventVote(vote);
            }
        }

        protected static Event InvokeUpdate(
            int event_id,
            object payload,
            UserSession session = null
            )
        {
            // Assume current session by default
            session = session ?? Server.FallbackToCurrentSession;

            // Negative event IDs are reserved for creating new events.
            var response = Server.Send(
                event_id < 0 ?
                    Server.event_url :
                    string.Format(Server.event_manage_url, event_id),
                session.token,
                event_id < 0 ? "POST" : "PUT",
                new
                {
                    // The API expects "event" which is reserved in C#
                    _event = payload
                },
                new JsonSerializerOptions
                {
                    // Fix the "event" issue
                    PropertyNamingPolicy = new FixReservedWordsNamingPolicy()
                }
            );

            if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);                
                return new Event(ParsedJson.Parse(reader.ReadToEnd()));
            }

            throw new Exception(Server.UnexpectedStatus(response.StatusCode));
        }
    }

    /// <summary>
    /// A class that overwrites names in JSON to fix issues with reserved words in C#.
    /// </summary>
    internal class FixReservedWordsNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            switch (name)
            {
                case "_event": return "event";
            }
            return name;
        }
    }
}
