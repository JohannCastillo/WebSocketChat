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
        private Panel pnlBase;
        private string username;
        public SelectFriendControl(Panel pnlBase, string username)
        {
            InitializeComponent();
            
            this.pnlBase = pnlBase;

            this.username = username;
            lblUserName.Text = username;
        }

        private void pnlFriend_Click(object sender, EventArgs e)
        {
            ChatControl chatControl = new ChatControl(username);
            pnlBase.Controls.Add(chatControl);
            chatControl.BringToFront();
        }
    }
}
