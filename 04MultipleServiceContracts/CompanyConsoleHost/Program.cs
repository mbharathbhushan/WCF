using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using _04MultipleServiceContracts;

namespace CompanyConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host= new ServiceHost(typeof(CompanyService)))
            {
                host.Open();
                Console.WriteLine("Application Deployted at " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
