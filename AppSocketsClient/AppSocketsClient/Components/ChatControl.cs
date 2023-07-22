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
        public ChatControl(string friend)
        {
            InitializeComponent();
            this.friend = friend;
            lblFriend.Text = friend;
        }

        public string Friend { get => friend; set => friend = value; }
    }
}
