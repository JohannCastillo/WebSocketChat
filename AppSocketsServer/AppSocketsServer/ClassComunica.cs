using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadidos
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Newtonsoft.Json;

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

        public void transmitirHilo(string texto)
        {
            Thread enviar = new Thread(() => transmitir(texto));
            enviar.Start();
        }

        public void recibirHilo(string ip)
        {
            myIp = ip;
            Thread rec = new Thread(() => recibir());
            rec.Start();
        }

        private void transmitir(string jsonStringified)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(jsonStringified);
            socketComunica.Send(messageBytes, SocketFlags.None);
            Console.WriteLine($"Socket client sent message: \"{jsonStringified}\"");
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

                    string recibidoString = Encoding.UTF8.GetString(buffer);
                    FormatoTipo recibidoObject = JsonConvert.DeserializeObject<FormatoTipo>(recibidoString);
                    
                    switch (recibidoObject.tipo)
                    {
                        case "M":
                            FormatoMensajeTexto objetoMensaje = JsonConvert.DeserializeObject<FormatoMensajeTexto>(recibidoString);
                            enviarMensajeAUser(objetoMensaje, recibidoString);
                            break;
                        case "C":
                            break;
                        case "D":
                            break;
                        case "L":
                            FormatoLoginEnvio objetoLoginEnvio = JsonConvert.DeserializeObject<FormatoLoginEnvio>(recibidoString);
                            aceptarLogin(objetoLoginEnvio);
                            break;
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void enviarMensajeAUser(FormatoMensajeTexto objeto, string objetoRecibidoString)
        {
            try
            {
                string destino = objeto.usuarioDestino;
                string emisor = objeto.usuarioOrigen;
                gobernador.usernameToClassComunica[destino].transmitirHilo(objetoRecibidoString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void aceptarLogin(FormatoLoginEnvio objetoLoginEnvio)
        {
            try
            {
                bool rpta = gobernador.continuarComunicacion(objetoLoginEnvio.usuario,objetoLoginEnvio.password, this);
                if (rpta)
                {
                    myUsername = objetoLoginEnvio.usuario;
                    FormatoLoginRespuesta objetoRespuestaLogin = new FormatoLoginRespuesta(myUsername, 1);
                    string serializado = JsonConvert.SerializeObject(objetoRespuestaLogin);
                    this.transmitirHilo(serializado); //CONTINUAR COMUNICACION ENTRAR A CHAT
                }else
                {
                    FormatoLoginRespuesta objetoRespuestaLogin = new FormatoLoginRespuesta(objetoLoginEnvio.usuario, 0);
                    string serializado = JsonConvert.SerializeObject(objetoRespuestaLogin);
                    this.transmitirHilo(serializado); //CONTINUAR COMUNICACION ENTRAR A CHAT
                    //this.transmitirHilo("L", user.PadRight(20), "0"); //RECHAZAR , QUEDARSE EN LOGIN
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
