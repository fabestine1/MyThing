using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MessagingService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class CMessage : IMessager, IAdmin
    {
        private List<User> users = new List<User>();
        private User loggedInUser;

        public void BlockUser(string username)
        {
            User user = users.Single(x => x.Username == username);
            user.IsBlocked = true;
            user.UserChannel.Blocked("You have been blocked by admin.");
        }

        public void Connect(string username)
        {
            User newUser = new User() { Username = username, IsBlocked = false, UserChannel = OperationContext.Current.GetCallbackChannel<IMessagerCallback>() };
            if (!users.Exists(x => x.Username == username))
            {
                newUser.UserChannel.LoginStatus(true, "Login is successful.");
                users.Add(newUser);
                loggedInUser = newUser;
                return;
            }
            newUser.UserChannel.LoginStatus(false, "Login is not successful.");
        }

        public void Disconnect()
        {
            users.Remove(loggedInUser);
            loggedInUser = null;
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public List<User> GetUsers()
        {
            return users.Where(x => x.IsBlocked == false).ToList();
        }

        public void SendMessage(string message, string username)
        {
            User receiver;
            if (!loggedInUser.IsBlocked && users.Exists(x => x.Username == username))
            {
                receiver = users.Single(x => x.Username == username);
                IMessagerCallback receiverCallback = receiver.UserChannel;
                if (!receiver.IsBlocked)
                {
                    string str = "(" + loggedInUser.Username + ")" + " private: (" + message + ")";
                    loggedInUser.UserChannel.ReceivedMessage(str);
                    receiverCallback.ReceivedMessage(str);
                }
            }
        }

        public void SendPublicMessage(string message)
        {
            List<User> notBlockedUsers = users.Where(x => x.IsBlocked == false).ToList();
            if (!loggedInUser.IsBlocked)
            {
                string str = "(" + loggedInUser.Username + "): (" + message + ")";
                foreach (User user in notBlockedUsers)
                {
                    if (!user.IsBlocked)
                    {
                        user.UserChannel.ReceivedMessage(str);
                    }
                }
            }
        }
    }
}
