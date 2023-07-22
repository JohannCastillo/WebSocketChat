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
        public Dictionary<string, ClassComunica> usernameToClassComunica = new Dictionary<string, ClassComunica>();
        private Dictionary<string, string> usuariosGuardados = new Dictionary<string, string>();

        //Aqui usar mejor una clase Chat (quizás tampoco se necesite esto)
        public List<List<string>> chatsGuardados = new List<List<string>>();

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

            usuariosGuardados.Add("juan", "user");
            usuariosGuardados.Add("martha", "user");
            usuariosGuardados.Add("carellano", "user");
            usuariosGuardados.Add("jose", "user");
        }

        public bool continuarComunicacion(string user, string passw, ClassComunica instanciaComunica)
        {
            bool rpta = false;
            try
            {
                rpta = usuariosGuardados[user] == passw;
                if (rpta)
                {
                    if(usernameToClassComunica.Count <= 6)
                    {
                        usernameToClassComunica.Add(user, instanciaComunica);
                    }else
                    {
                        rpta = false;
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Ocurrio error: " + ex.ToString());
            }
            return rpta;
        }

        public static ClassGeneral Instancia
        {
            get
            {
                return _instancia;
            }
        }


    }
}
