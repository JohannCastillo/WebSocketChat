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
        private readonly string username;
        private readonly bool isOnline;
        //Instancia del cliente

        public SelectFriendControl(Cliente client, string username, bool isOnline = true)
        {
            InitializeComponent();
    
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
            FrmChat parentForm = FindForm() as FrmChat;
            if (parentForm != null)
            {
                parentForm.bringToFrontChatControl(Username);
            }
        }
    }
}
