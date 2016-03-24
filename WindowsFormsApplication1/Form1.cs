using System;
using System.Windows.Forms;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        TcpClient clientSocket = new TcpClient();
        public Form1()
        {
            InitializeComponent();

            //PKServiceReference.IannounceClient myService = new PKServiceReference.IannounceClient();
            //myService.GetXMLData("112","", "2015-11-30");
            clientSocket.Connect("192.9.10.100", 2000);
            lblServerStatus.Text = "Client Socket Program - Server Connected ...";
            
        }

        private void btnClientSocket_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.Default.GetBytes(txtCommand.Text.Trim());
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            try
            {
                byte[] inStream = new byte[300000];
                serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                string returndata = System.Text.Encoding.Default.GetString(inStream);
                msg(returndata);
            }
            catch (Exception ex)
            {
                clientSocket.Close();
                throw ex;
            }
            
            
        }

        public void msg(string mesg)
        {
            tbxContent.Text = tbxContent.Text + Environment.NewLine + " >> " + mesg;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (true)
            {
                clientSocket.Close();
            }
        }
    }
}
