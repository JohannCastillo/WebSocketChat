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

namespace AppSocketsClient.Forms
{
    public partial class FrmChat : Form
    {
        private UserSession userSession;

        public FrmChat(UserSession userSession)
        {
            this.userSession = userSession;
            InitializeComponent();

            loadContacts();
        }

        private void loadContacts() { 

            foreach(string user in userSession.Users)
            {
                if (user == userSession.Username) continue;
                SelectFriendControl friend = new SelectFriendControl(pnlBase, user, userSession.OnlineUsers.Contains(user));
                pnlContacts.Controls.Add(friend);
            }
        }

        private void FrmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
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
    }
}
