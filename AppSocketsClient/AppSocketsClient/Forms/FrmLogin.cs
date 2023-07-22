using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppSocketsClient.Forms
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();

           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmChat frm = new FrmChat();
            frm.Show();
            this.Hide();
        }
    }
}
