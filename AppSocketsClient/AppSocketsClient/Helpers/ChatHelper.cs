using AppSocketsClient.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSocketsClient.Helpers
{
    internal class ChatHelper
    {
        private FlowLayoutPanel pnlMessages;

        public void Inicializa(FlowLayoutPanel panel)
        {
            // Fill the chat array with the chat.txt
            pnlMessages = panel;

        }
        public void AddOwnControl(string message)
        {
            OwnMessageControl omc = new OwnMessageControl { 
                MessageText = message,
            };

            pnlMessages.Controls.Add(omc);
            pnlMessages.ScrollControlIntoView(omc);
        }

        public void AddFriendControl(string message, string username)
        {
            FriendMessageControl fmc = new FriendMessageControl
            {
                MessageText = message,
                UserName = username
            };

            pnlMessages.Controls.Add(fmc);
            pnlMessages.ScrollControlIntoView(fmc);
        }
    }
}
