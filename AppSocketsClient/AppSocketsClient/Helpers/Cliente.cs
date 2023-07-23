using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace AppSocketsClient.Helpers
{
    internal class Cliente
    {
        private Socket cliente;
        private IPAddress ipServidor;
        
        //private byte[] arreglo;

        private Thread recepcionando;
        private byte[] arregloRecive;

        public Cliente()
        {
           
        }

        public bool conectar() {
            try
            {
                cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint IPEnd_Servidor = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 13000);

                cliente.Connect(IPEnd_Servidor);
               
                recepcionando = new Thread(recibe);
                recepcionando.Start();
                
                return true; 
            }
            catch (Exception ee)
            {
                //MessageBox.Show("se intento");
            }
            return false; 
        }

        private void recibe()
        {
            arregloRecive = new byte[1024];
            while (true)
            {

                cliente.Receive(arregloRecive);
                MessageBox.Show(ASCIIEncoding.UTF8.GetString(arregloRecive));
            }

        }

        public void enviar(string mensaje) {
            //var data = new
            //{
            //    tipo = tipo,
            //    user = user,
            //    mensaje = mensaje
            //};

            //string jsonString = JsonSerializer.Serialize(data);

         
            //byte[] buffer = Encoding.UTF8.GetBytes(jsonString);

         
            //socketComunica.Send(buffer);
        }
    }
}
