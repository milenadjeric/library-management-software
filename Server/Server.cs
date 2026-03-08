using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    internal class Server
    {
        private Socket socket;
        public static List<ClientHandler> clients = new List<ClientHandler>();

        public Server()
        {
            socket=new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);       
        }
        internal void Start()
        {
            //IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));

            socket.Bind(endPoint);
            socket.Listen(5);

            Thread thread = new Thread(AcceptClient);
            thread.Start();
        }

        private void AcceptClient()
        {
            try
            {
                while (true)
                {
                    Socket clientSocket = socket.Accept();
                    ClientHandler handler = new ClientHandler(clientSocket);
                    clients.Add(handler);
                    Debug.WriteLine(">>> Dodat handler:"+handler.ToString());
                    Thread clientThread = new Thread(handler.HandleRequest);
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                foreach (ClientHandler c in clients)
                {
                    Stop();
                }
            }
        }

        internal void Stop()
        {
            foreach (ClientHandler handler in clients) 
            { 
                handler.Close();
                Debug.WriteLine(">>> Zatvoren handler:" + handler.ToString());
            }
            clients.Clear();
            socket.Close();
        }
    }
}
