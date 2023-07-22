using AppSocketsClient.Components;
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
        
             
        public FrmChat()
        {
            InitializeComponent();

            loadContacts();
        }

        private void loadContacts() { 
            // Se llenan todos los usuarios con bucle, esto es solo de prueba, funciona
            SelectFriendControl friend = new SelectFriendControl(pnlBase, "Johann");

            pnlContacts.Controls.Add(friend);

            SelectFriendControl friend2 = new SelectFriendControl(pnlBase, "Bruno");

            pnlContacts.Controls.Add(friend2);

        }
    }
}
