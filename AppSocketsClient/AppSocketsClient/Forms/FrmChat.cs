using AppSocketsClient.Components;
using AppSocketsClient.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSocketsClient.Forms
{
    public partial class FrmChat : Form
    {
        private UserSession userSession;

        public FrmChat(UserSession userSession)
        {
            this.userSession = userSession;
            InitializeComponent();

            loadContacts();
        }

        private void loadContacts() { 

            foreach(string onlineUser in userSession.OnlineUsers)
            {
                if (onlineUser == userSession.Username) continue;
                SelectFriendControl friend = new SelectFriendControl(pnlBase, onlineUser);
                pnlContacts.Controls.Add(friend);
            }
        }

    }
}
