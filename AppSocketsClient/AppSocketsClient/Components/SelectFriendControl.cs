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
        private readonly string username;
        private readonly bool isOnline;

        //Almacenar chatControl ya añadidos al panel
        private static Dictionary<string, ChatControl> chatControls = new Dictionary<string, ChatControl>();

        public SelectFriendControl(Panel pnlBase, string username, bool isOnline = true)
        {
            InitializeComponent();
            
            this.pnlBase = pnlBase;

            this.username = username;
            lblUserName.Text = username;

            this.isOnline = isOnline;
            lblIsOnline.Visible = isOnline;
        }

        public string Username
        {
            get { return username; }
        }

        private void pnlFriend_Click(object sender, EventArgs e)
        {
            ChatControl chatControl;
            if (!chatControls.ContainsKey(Username))
            {
                chatControl = new ChatControl(Username);
                chatControls[Username] = chatControl;
                pnlBase.Controls.Add(chatControl);
            }
            else
            {
                chatControl = chatControls[Username];
            }
            chatControl.BringToFront();
        }
    }
}
