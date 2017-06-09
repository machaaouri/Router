using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FirstService
{
    public interface IService
    {
        /*
         * return the Winner from each and every year for the UEFA Champions League since 1955;
        */

        [OperationContractAttribute(Action = "http://UEFA/champWinner", ReplyAction = "http://UEFA/champWinnerRespone")]
        String ChampWinner(long year);
    }

    class Service : IService
    {
        // A dictionary to store the all the UEFA Champions League winners. 

        Dictionary<string, string> winners;

        Service()
        {
            // very odd to do this inside the constructor , but it's all about the load balancer not this service...
            try
            {
                using (StreamReader file = new StreamReader("Resources/UEFA.json"))
                {
                    string winnersJson = file.ReadToEnd();
                    winners = JsonConvert.DeserializeObject<Dictionary<string, string>>(winnersJson);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("An Exception occured : " + exception.Message);
            }
        }

        public string ChampWinner(long year)
        {
            throw new NotImplementedException();
        }
    }
}
