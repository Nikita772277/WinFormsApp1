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
        private async void Ser()
        {
            IPEndPoint IpPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            TcpListener listener = new TcpListener(IpPoint);
            try
            {
                listener.Start();
                using TcpClient client = await listener.AcceptTcpClientAsync();
                await using NetworkStream stream = client.GetStream();
                byte[] massage = new byte[200];
                while (true)
                {
                    int bytes = await stream.ReadAsync(massage);
                    if (bytes > 0)
                    {
                        string s = massage.ToString();
                        string x = Encoding.UTF8.GetString(massage);
                        Console.WriteLine(x);
                        Console.WriteLine(s);
                        bytes = 0;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch
            {
                listener.Stop();
            }
        }
    }
}
