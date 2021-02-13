using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerApp
{
    public class Server
    {
        private Socket listener;
        private List<ClientHandler> clients = new List<ClientHandler>();
        private BindingList<object> users = new BindingList<object>();
        public BindingList<object> Users
        {
            get { return users; }
        }

        public Server()
        {

        }
        

        public void Start()
        {

            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            listener.Bind(new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]),Int32.Parse( ConfigurationManager.AppSettings["port"])));
            listener.Listen(5);
        }

        

        public void Listen()
        {

            try
            {
                while (true)
                {
                    Socket client = listener.Accept();

                    ClientHandler handler = new ClientHandler(client, this);
                    clients.Add(handler);
                    Thread t = new Thread(handler.Listen);
                    t.IsBackground = true;
                    t.Start();
                }


            }
            catch (SocketException)
            {

                
            }

        }

        internal void Stop()
        {

            listener?.Close();

            foreach (var item in clients)
            {
                item.Close();
            }
            clients.Clear();
        }
    }
}
