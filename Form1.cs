using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;
using System.Text;

namespace ZavrsnaAplikacija
{
    public partial class Form1 : Form
    {

		
		static IPAddress ipAd = IPAddress.Parse("192.168.5.12");

		
		static int PortNumber = 8888;


		TcpListener ServerListener = new TcpListener(ipAd, PortNumber);
		TcpClient clientSocket = default(TcpClient);

		public Form1()
        {
            InitializeComponent();
			
		}
       

		
		private void Form1_Load(object sender, EventArgs e)
        {
			Thread ThreadingServer = new Thread(StartServer);
			ThreadingServer.Start();
		}
		private void THREAD_MOD(string teste)
		{
			richTextBox1.Text += Environment.NewLine + teste;
		}

		private void StartServer()
		{
			Action<string> DelegateTeste_ModifyText = THREAD_MOD;
			ServerListener.Start();
			Invoke(DelegateTeste_ModifyText, "Čekam...");
			clientSocket = ServerListener.AcceptTcpClient();
			Invoke(DelegateTeste_ModifyText, "Spreman!");

			while (true)
			{
				try
				{

					NetworkStream networkStream = clientSocket.GetStream();
					byte[] bytesFrom = new byte[20];
					networkStream.Read(bytesFrom, 0, 20);
					string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
					dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

					string serverResponse = "Primljeno!";
					Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
					networkStream.Write(sendBytes, 0, sendBytes.Length);
					networkStream.Flush();
				}
				catch
				{
					ServerListener.Stop();
					ServerListener.Start();
					Invoke(DelegateTeste_ModifyText, "Čekam poruku");
					clientSocket = ServerListener.AcceptTcpClient();
					Invoke(DelegateTeste_ModifyText, "Spreman za slanje/ primanje");
				}

			}
		}

		private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void circularButton1_Click(object sender, EventArgs e)
        {
			Pregled frm = new Pregled();
			frm.ShowDialog();
           
        }

		private void btnUnosStanja_Click(object sender, EventArgs e)
		{
			txtTemp form = new txtTemp();
			form.ShowDialog();
		}

		private void btnPretraga_Click(object sender, EventArgs e)
		{
			if (lblVentil.Text == "Zatvoren")
			{
				clientSocket = ServerListener.AcceptTcpClient();
				NetworkStream networkStream = clientSocket.GetStream();
				byte[] bytesFrom = new byte[20];
				string serverResponse = "Otvori";
				Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
				networkStream.Write(sendBytes, 0, sendBytes.Length);
				networkStream.Flush();
				lblVentil.Text = "Otvoren";
			}
			else
			{
				clientSocket = ServerListener.AcceptTcpClient();
				NetworkStream networkStream = clientSocket.GetStream();
				byte[] bytesFrom = new byte[20];
				string serverResponse = "Zatvori";
				Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
				networkStream.Write(sendBytes, 0, sendBytes.Length);
				networkStream.Flush();
				lblVentil.Text = "Zatvoren";
			}
		}
	}
}
