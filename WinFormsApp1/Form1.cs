using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool chek = true;
        protected string _name = "";
        public Form1()
        {
            _name = "User 1";
            InitializeComponent();
            //Server server = new Server();
            //server.Ser();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void Cl(string name)
        {
            using TcpClient tcpClient = new TcpClient();
            try
            {
                tcpClient.ConnectAsync("127.0.0.1", 8888);
            }
            catch
            {
                await Console.Out.WriteLineAsync("Клиент не подключился");
            }
            if (tcpClient.Connected)
            {
                var stream = tcpClient.GetStream();
                Console.WriteLine($"Подключение с {tcpClient.Client.RemoteEndPoint} установленно");
                while (stream != null)
                {
                        byte[] mes = Encoding.UTF8.GetBytes(textBox1.Text);
                        try
                        {
                            if (textBox1.Text == "" || textBox1.Text[0] == ' ')
                                textBox1.Text.Trim();
                            if (textBox1.Text.Length > 0 && textBox1.Text != " ")
                            {
                                Console.WriteLine($"{name}: {textBox1.Text}");
                            }
                            stream.WriteAsync(mes);
                            stream = null;
                        }
                        catch
                        {
                            Console.WriteLine("сервер временно недоступен");
                        }
                }
            }
            else
            {
                await Console.Out.WriteLineAsync("Не удалось подключиться");
            }
        }
        private void ToSend_Click(object sender, EventArgs e)
        {
            if ((chek && textBox1.Text != "") && (textBox1.Text != null && chek))
                richTextBox1.Text += $"{_name}: {textBox1.Text} \r\n";
            Console.WriteLine($"{_name}: {textBox1.Text} ");
            textBox1.Text = "";
        }
        void this_MouseWheel(object sender, MouseEventArgs e)
        {
            if (chek)
            {
                if (e.Delta > 0)
                    Console.WriteLine();
                else
                    Console.WriteLine();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (chek)
            {
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cl(_name);
        }
    }
}