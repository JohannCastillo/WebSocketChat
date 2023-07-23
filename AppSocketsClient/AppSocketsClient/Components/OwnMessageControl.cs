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
    public partial class OwnMessageControl : UserControl
    {

        public OwnMessageControl()
        {
            InitializeComponent();
            MessageText = "hello";
            MessageDate = DateTime.Now;
        }

        public string MessageText
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }
        public DateTime MessageDate
        {
            get { return DateTime.Parse(lblDate.Text); }
            set { lblDate.Text = DateTime.Now.Day == value.Day ? value.ToString("hh:mm tt") : value.ToString("d/MM/yyyy hh:mm tt"); }
        }
    }
}
