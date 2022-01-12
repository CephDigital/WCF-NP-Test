using System;
using System.ServiceModel;
using System.Windows.Forms;
using WCFInterfaces;
using WCFServices;

namespace WCFHostControl
{
    public partial class Control : UserControl
    {
        ServiceHost serviceHost;
        public Control()
        {
            InitializeComponent();
            serviceHost = new ServiceHost(
                typeof(WCFService), new Uri[] { new Uri("net.pipe://localhost/WCFTest") });
            serviceHost.AddServiceEndpoint(typeof(IWCFService), new NetNamedPipeBinding(), "WCFClient");
        }

        static void Main()
        {
            
        }

        public void startHost()
        {
            if (serviceHost.State != CommunicationState.Opened)
            {
                serviceHost.Open();
            }
        }

        public void stopHost()
        {
            if (serviceHost.State != CommunicationState.Closed)
            {
                serviceHost.Close();
            }
        }
    }
}