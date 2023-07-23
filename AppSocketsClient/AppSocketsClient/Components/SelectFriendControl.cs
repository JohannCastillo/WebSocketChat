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
        private readonly Panel pnlBase;

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

        public string Username { get; set; }

        public SelectFriendControl(Panel pnlBase, string username, bool isOnline = true)
        {
            InitializeComponent();

            this.pnlBase = pnlBase;

            Username = username;
            lblUserName.Text = username;

            IsOnline = isOnline;
        }

        private void UpdateIsOnlineVisibility()
        {
            lblIsOnline.Visible = IsOnline;
        }

        private void pnlFriend_Click(object sender, EventArgs e)
        {
            ChatControl chatControl = new ChatControl(Username);
            pnlBase.Controls.Add(chatControl);
            chatControl.BringToFront();
        }
    }
}
