using System;
using System.Windows.Forms;

namespace _03WindowsApplicationTCPBinding
{
    public partial class Form1 : Form
    {
        private HttpService.HelloServiceClient helloServiceClient;
        public Form1()
        {
            InitializeComponent();
            helloServiceClient = new HttpService.HelloServiceClient("NetTcpBinding_IHelloService");

            txtResult.Text = helloServiceClient.GetMessage(DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));
        }
    }
}
