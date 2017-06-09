using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SecondService
{
    class Program
    {
        static void Main(string[] args)
        {
             Uri baseAddress = new Uri("http://localhost:8080/SecondService");

             using (ServiceHost host = new ServiceHost(typeof(SecondService), baseAddress))
             {
                 // Open the ServiceHost to start listening for messages ( this is a self-hosted service )
                 host.Open();

                 Console.WriteLine("The service is ready at {0}", baseAddress);
                 Console.WriteLine("Press <enter> to stop the service.");
                 Console.ReadLine();

                 host.Close();
             }
        }
    }
}
