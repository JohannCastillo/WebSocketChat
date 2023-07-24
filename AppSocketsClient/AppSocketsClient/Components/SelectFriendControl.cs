using AppSocketsClient.Forms;
using AppSocketsClient.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSocketsClient.Components
{
    public partial class SelectFriendControl : UserControl
    {
        string username;
        string lastMessage; 

        private bool isOnline;


        public bool IsOnline
        {
            get { return isOnline; }
            set
            {
                if (isOnline != value)
                {
                    isOnline = value;
                    UpdateIsOnlineVisibility();
                }
            }
        }

  

        public SelectFriendControl(string username, bool isOnline = true)
        {
            InitializeComponent();

            this.username = username;
            lblUserName.Text = username;

            IsOnline = isOnline;
            lastMessage = "";
        }

        private void UpdateIsOnlineVisibility()
        {
            lblIsOnline.Visible = IsOnline;
        }

        public string Username
        {
            get { return username; }
            set { username = value; } 
        }

        public string LastMessage {
            get { return lastMessage; }
            set { 
                lastMessage = value;
                lblLastMessage.Text = value;
            }
        }

        private void pnlFriend_Click(object sender, EventArgs e)
        {
            FrmChat parentForm = FindForm() as FrmChat;
            if (parentForm != null)
            {
                parentForm.bringToFrontChatControl(Username);
            }
        }
    }
}
