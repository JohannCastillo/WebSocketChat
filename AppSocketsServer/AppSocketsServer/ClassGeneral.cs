using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSocketsServer
{
    class ClassGeneral
    {
        private readonly static ClassGeneral _instancia = new ClassGeneral();
        private Dictionary<string, ClassComunica> usernameConectadosToClassComunica = new Dictionary<string, ClassComunica>();
        private Dictionary<string, string> usuariosGuardados = new Dictionary<string, string>();
        private readonly object conectadosLock = new object();
        //Aqui usar mejor una clase Chat (quizás tampoco se necesite esto)
        //public List<List<string>> chatsGuardados = new List<List<string>>();

        private ClassGeneral()
        {
            popularUsuarios();
        }

        private void popularUsuarios()
        {
            usuariosGuardados.Add("bruno", "admin");
            usuariosGuardados.Add("johann", "admin");
            usuariosGuardados.Add("angello", "admin");
            usuariosGuardados.Add("hiroshi", "admin");

            usuariosGuardados.Add("abraham", "user");
            usuariosGuardados.Add("martha", "user");
            usuariosGuardados.Add("carellano", "user");
            usuariosGuardados.Add("julio", "user");

            usuariosGuardados.Add("willy", "user");
            usuariosGuardados.Add("david", "user");
            usuariosGuardados.Add("piero", "user");
            usuariosGuardados.Add("jambri", "user");
        }

        public int obtenerEstadoComunicacion(string user, string passw)
        {
            //1 = continuar
            //2 = error no más conexiones
            //3 = error usuario no existe
            //4 = error passw incorrecto
            //5 = error usuario ya conectado

            int rpta = 1;
            if(usernameConectadosToClassComunica.Count >= 6) //ya hay 6
            {
                rpta = 2; //ya hay 6 conectados
                return rpta;
            }

            try
            {
                if(usuariosGuardados[user] != passw)
                {
                    rpta = 4; //contraseña incorrecta
                    return rpta;
                }
            }
            catch (Exception ex)
            {
                //error por usuario inexistente
                rpta = 3;
                return rpta;
            }

            if (usernameConectadosToClassComunica.Keys.ToArray<string>().Contains(user))
            {
                rpta = 5; //usuario ya está conectado
                return rpta;
            }

            return rpta;
        }

        public void agregarUsuarioAConectados(string user, ClassComunica instanciaComunica)
        {
            lock (conectadosLock)
            {
                usernameConectadosToClassComunica.Add(user, instanciaComunica);
            }
        }

        public static ClassGeneral Instancia
        {
            get
            {
                return _instancia;
            }
        }

        public void desconectarUsuario(string user)
        {
            lock (conectadosLock)
            { 
                usernameConectadosToClassComunica.Remove(user);
            }
        }

        public Dictionary<string, ClassComunica> getUsuariosConectados()
        {
            lock (conectadosLock)
            {
                return usernameConectadosToClassComunica;
            }
        }

    }
}
