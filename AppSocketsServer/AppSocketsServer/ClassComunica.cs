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
        //private Dictionary<string, List<String>> misChats = new Dictionary<string, List<string>>();

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
            try
            {
                byte[] messageBytes = Encoding.UTF8.GetBytes(jsonStringified);
                socketComunica.Send(messageBytes, SocketFlags.None);
                Console.WriteLine($"Socket client sent message: \"{jsonStringified}\"");
            }
            catch (SocketException ex)
            {
                // Manejar la excepción
                Console.WriteLine($"Socket exception transmitiendo: {ex.Message}");
                // También puedes cerrar el socket u otras acciones necesarias
            }
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

                    if (recibidoObject == null) continue;
                    switch (recibidoObject.tipo)
                    {
                        case "M":
                            FormatoMensajeTexto objetoMensaje = JsonConvert.DeserializeObject<FormatoMensajeTexto>(recibidoString);
                            enviarMensajeAUser(objetoMensaje, recibidoString);
                            break;
                        //case "C":
                        //    //Solo aplica para cliente
                        //    break;
                        case "D":
                            desconectarUsuario(recibidoString);
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
                gobernador.usernameConectadosToClassComunica[destino].transmitirHilo(objetoRecibidoString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void aceptarLogin(FormatoLoginEnvio objetoLoginEnvio)
        {
            string[] conectados = { };
            try
            {
                bool rpta = gobernador.continuarComunicacion(objetoLoginEnvio.usuario,objetoLoginEnvio.password, this);
                if (rpta)
                {
                    this.myUsername = objetoLoginEnvio.usuario;
                    conectados = gobernador.usernameConectadosToClassComunica.Keys.ToArray<string>();
                    Console.WriteLine(conectados);
                    FormatoLoginRespuesta objetoRespuestaLogin = new FormatoLoginRespuesta(myUsername, 1, conectados);
                    string serializado = JsonConvert.SerializeObject(objetoRespuestaLogin);
                    this.transmitirHilo(serializado); //CONTINUAR COMUNICACION ENTRAR A CHAT
                    avisarConexionUsuarioAOtros();
                }else
                {
                    FormatoLoginRespuesta objetoRespuestaLogin = new FormatoLoginRespuesta(objetoLoginEnvio.usuario, 0, conectados);
                    string serializado = JsonConvert.SerializeObject(objetoRespuestaLogin);
                    this.transmitirHilo(serializado); //NO PERMITIR CHAT
                    //this.transmitirHilo("L", user.PadRight(20), "0"); //RECHAZAR , QUEDARSE EN LOGIN
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void avisarConexionUsuarioAOtros()
        {
            FormatoNuevoUsuarioConectado fnuc = new FormatoNuevoUsuarioConectado(myUsername);
            string objectString = JsonConvert.SerializeObject(fnuc);
            foreach (string key in gobernador.usernameConectadosToClassComunica.Keys)
            {
                if(key != myUsername)
                {
                    gobernador.usernameConectadosToClassComunica[key].transmitirHilo(objectString);
                }
            }
        }

        private void desconectarUsuario(string objectString)
        {
            try
            {
                gobernador.desconectarUsuario(myUsername);
                foreach (string key in gobernador.usernameConectadosToClassComunica.Keys)
                {
                    gobernador.usernameConectadosToClassComunica[key].transmitirHilo(objectString);
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
    
}
