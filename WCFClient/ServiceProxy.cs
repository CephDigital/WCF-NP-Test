using System.ServiceModel;
using System.ServiceModel.Description;
using WCFInterfaces;

namespace WCFClient
{
    public class ServiceProxy : ClientBase<IWCFService>
    {
        public ServiceProxy()
            : base(new ServiceEndpoint(ContractDescription.GetContract(typeof(IWCFService)),
                   new NetNamedPipeBinding(), new EndpointAddress("net.pipe://localhost/WCFTest/WCFClient")))
        {

        }

        public string InvokeGetData(string input)
        {
            return Channel.GetData(input);
        }
    }
}
