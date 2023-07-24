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
//Añadidos
using Newtonsoft.Json;

namespace AppSocketsClient.Forms
{
    public partial class FrmLogin : Form
    {
        Cliente client;
        public FrmLogin()
        {
            InitializeComponent();

            client = new Cliente(this);
          
            conectarCliente();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUser.Text)) return;
            string usuario = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();
            
            FormatoLoginEnvio objetoLoginEnvio = new FormatoLoginEnvio(usuario, password);
            string objetoStringify = JsonConvert.SerializeObject(objetoLoginEnvio);
            client.enviar(objetoStringify);
            //FrmChat frm = new FrmChat();
            //frm.Show();
            //this.Hide();
        }

        public void LoginSucceed (UserSession userSession)
        {
            Invoke(new Action(() =>
            {
                FrmChat frmChat = new FrmChat(userSession, client);
                frmChat.Show();
                Hide();
            }));
        }

        public void LoginFailed(int e)
        {
            Invoke(new Action(() => {
                lblError.Text = "";
                lblError.Visible = false;
                lblPasswordError.Visible = false;
                lblUserError.Visible = false;
            }));

            switch (e)
            {
                case ((int)MensajeUtil.estadoComunicacion.NoMasConexiones):
                    Invoke(new Action(() => {
                        lblError.Visible = true;
                        lblError.Text = "No se aceptan más conexiones";
                    }));
                    break;
                case ((int)MensajeUtil.estadoComunicacion.UsuarioNoExiste):
                    Invoke(new Action(() => {
                        lblUserError.Visible = true;
                    }));
                    break;
                case ((int)MensajeUtil.estadoComunicacion.PasswIncorrecta):
                    Invoke(new Action(() => {
                        lblPasswordError.Visible = true;
                    }));
                    break;
                case ((int)MensajeUtil.estadoComunicacion.UsuarioYaConectado):
                    Invoke(new Action(() => {
                        lblError.Visible = true;
                        lblError.Text = "El usuario ya está conectado en otro cliente";
                    }));
                    break;
            }
        }


        private void btnTry_Click(object sender, EventArgs e)
        {
            conectarCliente();
        }

        private async void conectarCliente() {
           
            btnLogin.Enabled = false;
            lblConnectionState.Text = "Conectando ...";
          
            bool connected = await Task.Run(() => client.conectar());

            if (connected)
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

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.desconectar();
        }
    }
}
