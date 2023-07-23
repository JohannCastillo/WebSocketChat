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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppSocketsClient.Forms
{
    public partial class FrmLogin : Form
    {
        Cliente client;
        public FrmLogin()
        {
            InitializeComponent();

            client = new Cliente();

            conectarCliente();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmChat frm = new FrmChat();
            frm.Show();
            this.Hide();
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            conectarCliente();
        }

        private void conectarCliente() {
           
            btnLogin.Enabled = false;
            lblConnectionState.Text = "Conectando ...";
            Application.DoEvents();

            if (client.conectar())
            {
                lblConnectionState.Text = "Conectado";
                btnLogin.Enabled = true;
                btnTry.Visible = false;
            }
            else
            {
                lblConnectionState.Text = "No se pudo conectar al servidor";
            }
        }
    }
}
