using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Añadidos
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace AppSocketsServer
{
    public partial class Server : Form
    {
        private ClassGeneral gobernador = ClassGeneral.Instancia;
        IPEndPoint ipEndPoint;
        Socket socketPadre;
        public Server()
        {
            InitializeComponent();

            createServer();
        }

        public void createServer()
        {
            // establish the local end point for the socket 
            IPHostEntry ipHost = Dns.Resolve("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];

            ipEndPoint = new IPEndPoint(ipAddr, 13000); //colocar IPAdress.Any para 0.0.0.0

            // create a Tcp/Ip Socket 
            socketPadre = new Socket(ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            Thread listener = new Thread(listen);
            listener.Start();

            // Start listening for connections
        }

        public void listen()
        {
            socketPadre.Bind(ipEndPoint);
            socketPadre.Listen(10);
            // Start listening for connections 
            while (true)
            {
                try
                {
                    ClassComunica objeto = new ClassComunica();
                    Console.WriteLine("Waiting for a connection on port {0}", ipEndPoint);

                    // program is suspended while waiting for an incoming connection 
                    objeto.socketComunica = socketPadre.Accept();
                    string received = objeto.socketComunica.RemoteEndPoint.ToString();
                    objeto.recibirHilo(received);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"form exception listen: {e.Message}");
                }
            }

        }
    }
}
