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

        //Enum para facilitar la comprensión de los tipos de mensaje
 
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
                Console.WriteLine($"Socket server sent message: \"{jsonStringified}\"");
            }
            catch (SocketException ex)
            {
                // Manejar la excepción
                Console.WriteLine($"Socket server exception transmitiendo: {ex.Message}");
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
                        case (int)MensajeUtil.tipoMensaje.Mensaje:
                            FormatoMensajeTexto objetoMensaje = JsonConvert.DeserializeObject<FormatoMensajeTexto>(recibidoString);
                            enviarMensajeAUser(objetoMensaje, recibidoString);
                            break;
                        //case "C":
                        //    //Solo aplica para cliente
                        //    break;
                        case (int)MensajeUtil.tipoMensaje.UsuarioDesconectado:
                            desconectarUsuario(recibidoString);
                            break;
                        case (int)MensajeUtil.tipoMensaje.LoginSolicitud:
                            FormatoLoginEnvio objetoLoginEnvio = JsonConvert.DeserializeObject<FormatoLoginEnvio>(recibidoString);
                            aceptarLogin(objetoLoginEnvio);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"server recibir comunica: {ex.Message}");
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
                Console.WriteLine($"enviar mensaje comunica: {ex.Message}");
            }
            
        }

        private void aceptarLogin(FormatoLoginEnvio objetoLoginEnvio)
        {
            string[] conectados = { };
            try
            {
                int rpta = gobernador.obtenerEstadoComunicacion(objetoLoginEnvio.usuario,objetoLoginEnvio.password);
                if (rpta == 1)
                {
                    this.myUsername = objetoLoginEnvio.usuario;
                    conectados = gobernador.usernameConectadosToClassComunica.Keys.ToArray<string>();
                    FormatoLoginRespuesta objetoRespuestaLogin = new FormatoLoginRespuesta(myUsername, rpta, conectados);
                    string serializado = JsonConvert.SerializeObject(objetoRespuestaLogin);

                    gobernador.agregarUsuarioAConectados(myUsername, this); //agregar recien a conectados

                    this.transmitirHilo(serializado); //CONTINUAR COMUNICACION ENTRAR A CHAT
                    avisarConexionUsuarioAOtros();
                }else
                {
                    FormatoLoginRespuesta objetoRespuestaLogin = new FormatoLoginRespuesta(objetoLoginEnvio.usuario, rpta, conectados);
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
