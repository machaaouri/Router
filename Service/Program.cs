using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace FirstService
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] arguments = Environment.GetCommandLineArgs();
            Uri baseAddress = new Uri("http://localhost:" + arguments[1] + "/Service");

            using (ServiceHost host = new ServiceHost(typeof(Service), baseAddress))
            {
                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);

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
