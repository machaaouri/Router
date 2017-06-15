using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondService
{
    public class SecondService : IService.IService
    {
        // A dictionary to store the all the UEFA Champions League winners. 

        Dictionary<string, string> winners;

        SecondService()
        {
            Seed();   
        }


        private void Seed()
        {
            try
            {
                string filePath = "../../UEFA.json";

                using (StreamReader file = new StreamReader(filePath))
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
            String team;
            winners.TryGetValue(year.ToString(), out team);

            return (!String.IsNullOrEmpty(team) ? team : "Invalid year !");
        }
    }
}
