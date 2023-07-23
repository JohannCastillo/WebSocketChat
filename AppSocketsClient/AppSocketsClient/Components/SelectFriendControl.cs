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
        private readonly string username;
        private readonly string lastMessage;
        private readonly bool isOnline;
        public SelectFriendControl(Panel pnlBase, string username, string lastMessage = "quien sos", bool isOnline = true)
        {
            InitializeComponent();
            
            this.pnlBase = pnlBase;

            this.username = username;
            lblUserName.Text = username;

            this.lastMessage = lastMessage;
            lblLastMessage.Text = lastMessage;

            this.isOnline = isOnline;
            lblIsOnline.Visible = isOnline;
        }

        private void pnlFriend_Click(object sender, EventArgs e)
        {
            ChatControl chatControl = new ChatControl(username);
            pnlBase.Controls.Add(chatControl);
            chatControl.BringToFront();
        }
    }
}
