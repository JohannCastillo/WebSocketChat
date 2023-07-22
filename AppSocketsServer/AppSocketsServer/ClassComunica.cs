using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadidos
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace AppSocketsServer
{
    class ClassComunica
    {
        public Socket socketComunica;
        private ClassGeneral gobernador = ClassGeneral.Instancia;

        string myIp;
        string myUsername;

        //Aquí se puede usar mejor una clase Chat (este sí se debería usar)
        private Dictionary<string, List<String>> misChats = new Dictionary<string, List<string>>();

        public void transmitirHilo(string tipo, string user, string msg)
        {
            Thread enviar = new Thread(() => transmitir(tipo, user, msg));
            enviar.Start();
        }

        public void recibirHilo(string ip)
        {
            myIp = ip;
            Thread rec = new Thread(() => recibir());
            rec.Start();
        }

        private void transmitir(string tipo, string user, string msg)
        {
            string message = tipo + user.PadRight(20) + msg;
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            socketComunica.Send(messageBytes, SocketFlags.None);
            Console.WriteLine($"Socket client sent message: \"{message}\"");
        }

        private void recibir()
        {

            while (true)
            {
                try
                {
                    // Receive ack.
                    byte[] buffer = new byte[1024];
                    //var bufferRecibido =
                    socketComunica.Receive(buffer, SocketFlags.None);

                    string recibido = Encoding.UTF8.GetString(buffer, 0, 1);
                    string user = recibido.Substring(1, 20).Trim();
                    string tipo = recibido.Substring(0, 1);
                    switch (tipo)
                    {
                        case "M":
                            string mensaje = recibido.Substring(21);
                            enviarMensajeAUser(user, mensaje);
                            break;
                        case "A":
                            break;
                        case "R":
                            break;
                        case "L":
                            string password = recibido.Substring(21);
                            aceptarLogin(user, password);
                            break;
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void enviarMensajeAUser(string user, string mensaje)
        {
            try
            {
                string destino = user;
                string emisor = myUsername;
                gobernador.usernameToClassComunica[user].transmitirHilo("M", emisor, mensaje);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void aceptarLogin(string user, string password)
        {
            try
            {
                bool rpta = gobernador.continuarComunicacion(user,password, this);
                if (rpta)
                {
                    myUsername = user;
                    this.transmitirHilo("L",myUsername.PadRight(20), "1"); //CONTINUAR COMUNICACION ENTRAR A CHAT
                }else
                {
                    this.transmitirHilo("L", user.PadRight(20), "0"); //RECHAZAR , QUEDARSE EN LOGIN
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //private void verUserR(string user)
        //{
        //    string ip = UserToIp[user];

        //}

        //private void verUserE(string ip)
        //{
        //    string name = IpToUser[ip];
        //    msg = "M" + name.PadRight(20);
        //}

        //private void agregarUsuarioAPadre(byte[] buffer)
        //{
        //    string nombre = Encoding.UTF8.GetString(buffer, 1, 20).Trim();
        //    string password = "admin";

        //}
    }
    
}
