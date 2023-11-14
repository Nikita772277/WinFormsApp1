using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Cl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void Cl()
        {
            using TcpClient tcpClient = new TcpClient();
            Console.WriteLine("������ ");
            try
            {
                await tcpClient.ConnectAsync("127.0.0.1", 8888);
            }
            catch
            {
                await Console.Out.WriteLineAsync("������ �� �����������");
            }
            string message = "";
            if (tcpClient.Connected)
            {
                var stream = tcpClient.GetStream();
                Console.WriteLine($"����������� � {tcpClient.Client.RemoteEndPoint} ������������");
                while (stream != null)
                {
                    message = Console.ReadLine();
                    byte[] mes = Encoding.UTF8.GetBytes(message);
                    await stream.WriteAsync(mes);
                }
            }
            else
            {
                await Console.Out.WriteLineAsync("�� ������� ������������");
            }
        }
    }
}