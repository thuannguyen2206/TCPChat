using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        //TcpListener server;
        TcpClient client;
        StreamReader reader;
        StreamWriter writer;
        string mess;

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                btnStart.Hide();
                btnStop.Show();
                btnSend.Enabled = true;

                TcpListener server = new TcpListener(IPAddress.Any, Convert.ToInt32(txtboxPort.Text));
                server.Start();
                richTextBox1.Text += "Server starting ...\n";
                client = server.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);
                writer.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // Nhận tin nhắn từ Client
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while(client.Connected)
            {
                try
                {
                    string mess = reader.ReadLine();
                    richTextBox1.Invoke(new MethodInvoker(delegate ()
                    {
                        richTextBox1.Text += "\nClient: " + mess;
                    }));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        // Gửi tin nhắn ngược lại cho Client
        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                writer.WriteLine(mess);
                richTextBox1.Invoke(new MethodInvoker(delegate ()
                {
                    richTextBox1.Text += "\nServer: " + mess;
                }));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            mess = txtboxMessage.Text;
            if (mess.Length > 0)
            {
                backgroundWorker2.RunWorkerAsync();
            }
            txtboxMessage.Text = "";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null && client.Client != null && client.Client.Connected)
                {
                    MessageBox.Show("Không thể đóng Server vì vẫn còn client đang kết nối", "Thông báo");
                }
                else
                {
                    client.Close();
                    Application.Exit();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                
        }

        private void Server_Load(object sender, EventArgs e)
        {
            btnStop.Hide();
            btnSend.Enabled = false;
        }
    }
}
