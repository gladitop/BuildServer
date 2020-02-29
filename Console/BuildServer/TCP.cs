using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BuildServer
{
    static public class TCP
    {
        static Socket server = null;
        static int port = 987;
        static int MaxListen = 10;

        static public void Start()
        {
            try
            {
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Bind(new IPEndPoint(IPAddress.Any, port));
                server.Listen(MaxListen);
                Thread thread = new Thread(new ThreadStart(Listen));
                thread.Start();
            }
            catch { }
        }

        static public void Listen()
        {
            while (true)
            {
                Task.Delay(10).Wait();

                Socket client = server.Accept();
                Thread thread = new Thread(new ParameterizedThreadStart(ClientListen));
                thread.Start(client);
            }
        }

        static public void ClientListen(object i)
        {
            Socket client = (Socket)i;
            bool iswhile = true;
            byte[] buffer = new byte[1024];

            while (iswhile)
            {
                Task.Delay(10).Wait();

                int messi = client.Receive(buffer);
            }
        }

        static public void Stop()
        {
            
        }
    }
}
