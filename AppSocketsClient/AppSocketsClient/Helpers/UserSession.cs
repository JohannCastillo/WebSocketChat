using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSocketsClient.Helpers
{
    public class UserSession
    {
        public string Username { get; set; }
        public List<string> OnlineUsers { get; set; }

        public List<string> Users { get; set; }

        public UserSession(string username, string[] onlineusers = null)
        {
            Username = username;
            OnlineUsers = onlineusers != null ? new List<string>(onlineusers) : new List<string>();
            Users = OnlineUsers;
        }
    }
}
