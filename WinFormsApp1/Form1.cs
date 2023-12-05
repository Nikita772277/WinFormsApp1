using System.IO;
using System.Net.Sockets;
using System.Reflection;
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
        private bool _connectingToTheServer;
        private TcpClient _tcpClient;
        private NetworkStream stream;
        public Form1()
        {
            _tcpClient = new TcpClient();
            _name = "User 1";
            _connectingToTheServer = false;
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private NetworkStream x()
        {
            try
            {
                _tcpClient.ConnectAsync("192.168.0.130", 88);
            }
            catch
            {
                richTextBox1.Text += ("Клиент не подключился");
            }
            string messeg = "";
            if (_tcpClient.Connected)
            {
                var stream = _tcpClient.GetStream();
                richTextBox1.Text += ($"Подключение с {_tcpClient.Client.RemoteEndPoint} установленно");
                _connectingToTheServer = true;
                return stream;
            }
            else
            {
                richTextBox1.Text += $"Не удалось подключиться \r\n";
            }
            return stream;
        }
        private void Cl(string name, NetworkStream stream)
        {
            while (_connectingToTheServer == true)
            {
                if (stream != null)
                {
                    byte[] mes = Encoding.UTF8.GetBytes(textBox1.Text);
                    try
                    {
                        if (textBox1.Text == "" || textBox1.Text[0] == ' ')
                            textBox1.Text.Trim();
                        if (textBox1.Text.Length > 0 && textBox1.Text != " ")
                        {
                            richTextBox1.Text += ($"\r\n{name}: {textBox1.Text}");
                        }
                        stream.WriteAsync(mes);
                        stream = null;
                    }
                    catch
                    {
                        richTextBox1.Text += $"сервер временно недоступен \r\n";
                    }
                }
                else
                    break;
            }
        }
        private void ToSend_Click(object sender, EventArgs e)
        {
            Cl(_name, stream);
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
            x();
            stream = x();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == " ")
            {
                MessageBox.Show("Имя не должно быть пустым");
            }
            else
            {
                textBox2.ReadOnly = true;
                _name = textBox2.Text;

                button2.Dispose();

            }
        }
    }
}