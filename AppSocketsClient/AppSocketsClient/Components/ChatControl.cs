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

namespace AppSocketsClient.Components
{
    public partial class ChatControl : UserControl
    {
        private string friend;
        private readonly ChatControlHelper ch;
        public ChatControl(string friend)
        {
            InitializeComponent();
            this.friend = friend;
            lblFriend.Text = friend;
            ch = new ChatControlHelper();
            ch.Inicializa(pnlChat);
        }

        public string Friend { get { return friend; } set { friend = value; } }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMensaje.Text)) return;
            Enviar(txtMensaje.Text);
        }
        

        private void Enviar(string message)
        {
            ch.AddOwnControl(message);
            txtMensaje.Text = "";
        }

        private void txtMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enviar(txtMensaje.Text);
                e.SuppressKeyPress = true;
            }
        }

        private void pnlChatLayout_Paint(object sender, PaintEventArgs e)
        {

            //ch.AddOwnControl("Buenas tardes");
            //ch.AddFriendControl("Que tal", "Johann");

            if(pnlChat.Controls.Count > 0)
            {
                pnlChat.ScrollControlIntoView(pnlChat.Controls[pnlChat.Controls.Count - 1]);
            }
        }
    }
}
