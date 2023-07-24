using AppSocketsClient.Components;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AppSocketsClient.Forms
{
    public partial class FrmChat : Form
    {
        private UserSession userSession;
        private Cliente cliente;
        private readonly ChatControlHelper ch;
        private static Dictionary<string, ChatControl> ChatControls = new Dictionary<string, ChatControl>();

        public FrmChat(UserSession userSession, Cliente cliente)
        {
            this.cliente = cliente;
            this.userSession = userSession;
            this.cliente = cliente; 
            cliente.NuevoUsuarioConectado += NuevoUsuarioConectado;
            cliente.UsuarioDesconectado += UsuarioDesconectado;
            InitializeComponent();
            ch = new ChatControlHelper();
            this.cliente.MensajeRecibido += MensajeRecibido;
            loadContacts();
        }

        private void loadContacts() { 

            foreach(string user in userSession.Users)
            {
                if (user == userSession.Username) continue;
                AddSelectFriendControlToPanel(user);
            }
        }

        private void AddSelectFriendControlToPanel(string username)
        {

            SelectFriendControl friend = new SelectFriendControl(username, userSession.OnlineUsers.Contains(username));
            pnlContacts.Controls.Add(friend);
            
            //Create chatControl for new user
            ChatControl chatControl = new ChatControl(cliente, username);
            chatControl.SendToBack();
            ChatControls[username] = chatControl;
            pnlBase.Controls.Add(chatControl);
        }

        private void SetOfflineToControl (string username)
        {

            SelectFriendControl friend = pnlContacts.Controls.OfType<SelectFriendControl>().FirstOrDefault(control => control.Username == username);
            friend.IsOnline = false;
        }

        private void NuevoUsuarioConectado (object sender, string username)
        {
            userSession.OnlineUsers.Add(username);
            if(!userSession.Users.Contains(username)) userSession.Users.Add(username);
            Invoke(new Action(() => {
                AddSelectFriendControlToPanel(username);
            }));
        }

        private void MensajeRecibido(object sender, string mssge, string friend)
        {
            MessageBox.Show(mssge + "   from: " + friend);
            ChatControl chatControl = ChatControls[friend];
           
            Invoke(new Action(() => {
                ch.Inicializa(chatControl.PnlChat);
                ch.AddFriendControl(mssge, friend);
            }));
        }
        private void UsuarioDesconectado(object sender, string username)
        {
            Invoke(new Action(() => {
                SetOfflineToControl(username);
            }));
        }


        private void FrmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            cliente.DesconectarUsuario(userSession.Username);


            // Crea una lista de formularios ocultos
            List<Form> formulariosOcultos = new List<Form>();

            // Recorre todos los formularios abiertos en la aplicación
            foreach (Form form in Application.OpenForms)
            {
                // Si el formulario está oculto, agrega a la lista
                if (!form.Visible)
                {
                    formulariosOcultos.Add(form);
                }
            }

            // Cierra los formularios ocultos fuera del bucle foreach
            foreach (Form form in formulariosOcultos)
            {
                form.Close();
            }
        }

        public void bringToFrontChatControl(string username) {
            //Quiero ejecutar esta función desde el  SelectFriendControl friend creado y al que se le envía la instancia de este form
            ChatControl chatControl = ChatControls[username];

            chatControl.BringToFront();
        }
    }
}
