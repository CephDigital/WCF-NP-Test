using System;
using System.ServiceModel;
using System.Windows.Forms;
using WCFInterfaces;

namespace WCFClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceProxy proxy = new ServiceProxy();
            outputLabel.Text = proxy.InvokeGetData(inputTextbox.Text);
        }
    }
}
