using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppSocketsClient.Helpers
{
    public static class MensajeUtil
    {
        public enum tipoMensaje
        {
            Mensaje,
            LoginSolicitud,
            LoginRespuesta,
            UsuarioConectado,
            UsuarioDesconectado
        }

        public enum estadoComunicacion
        {
            _,
            Continuar,
            NoMasConexiones,
            UsuarioNoExiste,
            PasswIncorrecta,
            UsuarioYaConectado
        }
    }
    class FormatoTipo
    {
      
        [JsonProperty("tipo")]
        public int tipo;
        public FormatoTipo(int tipo)
        {
            this.tipo = tipo;
        }
    }
    class FormatoMensajeTexto
    {
        public int tipo;
        public string usuarioOrigen;
        public string usuarioDestino;
        public string mensaje;

        public FormatoMensajeTexto(string usuarioOrigen, string usuarioDestino, string mensaje)
        {
            this.tipo = (int)MensajeUtil.tipoMensaje.Mensaje;
            this.usuarioOrigen = usuarioOrigen;
            this.usuarioDestino = usuarioDestino;
            this.mensaje = mensaje;
        }
    }

    class FormatoLoginEnvio
    {
        public int tipo;
        public string usuario;
        public string password;

        public FormatoLoginEnvio(string usuario, string password)
        {
            this.tipo = (int)MensajeUtil.tipoMensaje.LoginSolicitud;
            this.usuario = usuario;
            this.password = password;
        }
    }

    class FormatoLoginRespuesta
    {
        public int tipo;
        public string usuario;
        public int estado; //1 aceptado 0 rechazado
        public string[] conectados;

        public FormatoLoginRespuesta(string usuario, int estado, string[] conectados)
        {
            this.tipo = (int)MensajeUtil.tipoMensaje.LoginRespuesta;
            this.usuario = usuario;
            this.estado = estado;
            this.conectados = conectados;
        }
    }
    class FormatoNuevoUsuarioConectado
    {
        public int tipo;
        public string usuario;

        public FormatoNuevoUsuarioConectado(string usuario)
        {
            this.tipo = (int)MensajeUtil.tipoMensaje.UsuarioConectado; //Conectado
            this.usuario = usuario;
        }
    }

    class FormatoUsuarioDesconectado
    {
        public int tipo;
        public string usuario;

        public FormatoUsuarioDesconectado(string usuario)
        {
            this.tipo = (int)MensajeUtil.tipoMensaje.UsuarioDesconectado; //Desconectado
            this.usuario = usuario;
        }
    }
}
