using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        TcpClient client;
        StreamReader reader;
        StreamWriter writer;
        string mess;
        private void btnSend_Click(object sender, EventArgs e)
        {
            mess = txtboxMessage.Text;
            if (mess.Length > 0)
            {
                backgroundWorker2.RunWorkerAsync();
            }
            txtboxMessage.Text = "";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(txtboxIP.Text), Convert.ToInt32(txtboxPort.Text));
            client = new TcpClient();
            try
            {
                btnConnect.Enabled = false;
                btnSend.Enabled = true;
                txtboxMessage.Enabled = true;
                client.Connect(ep);
                if (client.Connected)
                {
                    richTextBox1.Text += "Connected to server\n";
                    NetworkStream stream = client.GetStream();
                    reader = new StreamReader(stream);
                    writer = new StreamWriter(stream);
                    writer.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }

            }
            catch (Exception ex)
            {
                btnConnect.Enabled = true;
                btnSend.Enabled = false;
                txtboxMessage.Enabled = false;
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            txtboxMessage.Enabled = false;
        }

        // Nhận tin nhắn từ Server
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    string mess = reader.ReadLine();
                    richTextBox1.Invoke(new MethodInvoker(delegate ()
                    {
                        richTextBox1.Text += "\nServer: " + mess;
                    }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        // Gửi tin nhắn cho server
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                writer.WriteLine(mess);
                richTextBox1.Invoke(new MethodInvoker(delegate ()
                {
                    richTextBox1.Text += "\nClient: " + mess;
                }));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();
        }
    }
}
