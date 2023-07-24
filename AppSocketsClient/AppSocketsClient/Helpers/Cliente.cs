using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//Añadidos
using Newtonsoft.Json;
using AppSocketsClient.Forms;

namespace AppSocketsClient.Helpers
{
    public class Cliente
    {
        private Socket cliente;
        private IPAddress ipServidor;
        
        //private byte[] arreglo;

        private Thread recepcionando;
        private byte[] arregloRecive;
        private FrmLogin frmLogin;

        public delegate void NuevoUsuarioConectadoHandler(object sender, string username);
        public event NuevoUsuarioConectadoHandler NuevoUsuarioConectado;

        public delegate void MensajeRecibidoHandler(object sender, string mssge, string friend);
        public event MensajeRecibidoHandler MensajeRecibido;
        public delegate void UsuarioDesconectadoHandler(object sender, string username);
        public event UsuarioDesconectadoHandler UsuarioDesconectado;

        public Cliente(FrmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
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

        public void desconectar ()
        {
            try
            {
                if (cliente != null && cliente.Connected)
                {
                    recepcionando.Abort();
                    cliente.Shutdown(SocketShutdown.Both);
                    cliente.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al desconectar
                Console.WriteLine("Error desconexión" + ex.Message);
            }
        }

        private void recibe()
        {
            try
            {
                while (true)
                {
                    arregloRecive = new byte[1024];
                    cliente.Receive(arregloRecive);
                    string stringRecibido = ASCIIEncoding.UTF8.GetString(arregloRecive);
                    FormatoTipo recibidoObject = JsonConvert.DeserializeObject<FormatoTipo>(stringRecibido);

                    if (recibidoObject == null) continue;
                    switch (recibidoObject.tipo)
                    {
                        case (int)MensajeUtil.tipoMensaje.LoginRespuesta:
                            FormatoLoginRespuesta objetoLoginRpta = JsonConvert.DeserializeObject<FormatoLoginRespuesta>(stringRecibido);

                            switch (objetoLoginRpta.estado)
                            {
                                case ((int)MensajeUtil.estadoComunicacion.Continuar):
                                    UserSession userSession = new UserSession(objetoLoginRpta.usuario, objetoLoginRpta.conectados);
                                    frmLogin.LoginSucceed(userSession);
                                    break;
                                default:
                                    frmLogin.LoginFailed(objetoLoginRpta.estado);
                                    break;
                            }
                            break;

                        case (int)MensajeUtil.tipoMensaje.UsuarioConectado:
                            FormatoNuevoUsuarioConectado nuevo = JsonConvert.DeserializeObject<FormatoNuevoUsuarioConectado>(stringRecibido);
                            OnNuevoUsuarioConectado(nuevo.usuario);
                            break;

                        case (int)MensajeUtil.tipoMensaje.UsuarioDesconectado:
                            FormatoNuevoUsuarioConectado sefue = JsonConvert.DeserializeObject<FormatoNuevoUsuarioConectado>(stringRecibido);
                            OnUsuarioDesconectado(sefue.usuario);
                            break;

                        case (int)MensajeUtil.tipoMensaje.Mensaje:
                            FormatoMensajeTexto objetoMensaje = JsonConvert.DeserializeObject<FormatoMensajeTexto>(stringRecibido);
                            OnMensajeRecibido(objetoMensaje.mensaje, objetoMensaje.usuarioOrigen);
                            break;

                    }


                }
            } catch (ThreadAbortException ex) {
                throw;
            } catch (Exception ex)
            {
                MessageBox.Show("recibiendo: " + ex.Message);
            }
          

        }

        public void enviar(string mensaje)
        {
            try
            {
                byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                cliente.Send(msg);
            }
            catch (Exception ex)
            {
                   MessageBox.Show(ex.Message);
            }
        }

        public void DesconectarUsuario (string username)
        {
            FormatoUsuarioDesconectado usuarioDesconectado = new FormatoUsuarioDesconectado(username);
            string objetoStringify = JsonConvert.SerializeObject(usuarioDesconectado);
            enviar(objetoStringify);
        }

        protected virtual void OnNuevoUsuarioConectado (string username)
        {
            if (NuevoUsuarioConectado == null) return;
            NuevoUsuarioConectado(this, username);
        }

        protected virtual void OnMensajeRecibido(string mssge, string friend)
        {
            if (MensajeRecibido == null) return;
            MensajeRecibido(this, mssge, friend);
        }
        protected virtual void OnUsuarioDesconectado(string username)
        {
            if (UsuarioDesconectado == null) return;
            UsuarioDesconectado(this, username);
        }
    }
}
