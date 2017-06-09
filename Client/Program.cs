using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress("http://localhost:8080/FirstService");
            var channelFactory = new ChannelFactory<IService.IService>(binding, endpoint);

            IService.IService client = null;

            try
            {
                client = channelFactory.CreateChannel();
                string response = client.ChampWinner(1555);
                Console.WriteLine(response);
                Console.ReadKey();
                ((ICommunicationObject)client).Close();
            }
            catch
            {
                if (client != null)
                {
                    ((ICommunicationObject)client).Abort();
                }
            }
            Console.ReadKey();
        }
    }
}
