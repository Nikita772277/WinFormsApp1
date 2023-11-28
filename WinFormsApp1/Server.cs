using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    internal class Server
    {

        public Server()
        {

        }

        public void Ser()
        {
            IPEndPoint IpPoint = new(IPAddress.Parse("127.0.0.1"), 8888);
            TcpListener listener = new(IpPoint);
            listener.Start();
            //try
            //{
            //    using TcpClient client = listener.AcceptTcpClient();
            //    using NetworkStream stream = client.GetStream();
            //    while (true)
            //    {
            //        byte[] massage = new byte[200];
            //        int bytes = stream.Read(massage);
            //        if (bytes > 0)
            //        {
            //            string x = Encoding.UTF8.GetString(massage);
            //            Console.WriteLine(x);
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}
            //catch
            //{
            //    listener.Stop();
            //}
        }
    }
}
