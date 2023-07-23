using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppSocketsServer
{
    class FormatoTipo
    {
        [JsonProperty("tipo")]
        public string tipo;
        public FormatoTipo(string tipo)
        {
            this.tipo = tipo;
        }
    }
    class FormatoMensajeTexto
    {
        public string tipo;
        public string usuarioOrigen;
        public string usuarioDestino;
        public string mensaje;
        
        public FormatoMensajeTexto(string usuarioOrigen, string usuarioDestino, string mensaje)
        {
            this.tipo = "M";
            this.usuarioOrigen = usuarioOrigen;
            this.usuarioDestino = usuarioDestino;
            this.mensaje = mensaje;
        }

        
    }

    class FormatoLoginEnvio
    {
        public string tipo;
        public string usuario;
        public string password;

        public FormatoLoginEnvio(string usuario, string password)
        {
            this.tipo = "L";
            this.usuario = usuario;
            this.password = password;
        }
    }

    class FormatoLoginRespuesta
    {
        public string tipo;
        public string usuario;
        public int estado; //1 aceptado 0 rechazado

        public FormatoLoginRespuesta(string usuario, int estado)
        {
            this.tipo = "L";
            this.usuario = usuario;
            this.estado = estado;
        }
    }
    class FormatoNuevoUsuarioConectado
    {
        public string tipo;
        public string usuario;

        public FormatoNuevoUsuarioConectado(string usuario)
        {
            this.tipo = "C"; //Conectado
            this.usuario = usuario;
        }
    }

    class FormatoUsuarioDesconectado
    {
        public string tipo;
        public string usuario;

        public FormatoUsuarioDesconectado(string usuario)
        {
            this.tipo = "D"; //Desconectado
            this.usuario = usuario;
        }
    }
}
