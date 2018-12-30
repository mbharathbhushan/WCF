using System;
using System.ServiceModel;
namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(_03_WCFService.HelloService)))
            {

                host.Open();

                Console.WriteLine("Host Started at " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}

