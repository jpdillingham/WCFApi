using System;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCFApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://localhost:80";
            var host = new WebServiceHost(typeof(Service), new Uri(url));
            var endpoint = host.AddServiceEndpoint(typeof(IService), new WebHttpBinding(), "");
            host.Open();

            Console.WriteLine($"Api hosted at {url}.  Press any key to exit.");
            Console.ReadKey();
        }
    }

    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        string HelloWorld();
    }

    public class Service : IService
    {
        public string HelloWorld()
        {
            return "Hello World!";
        }
    }
}
