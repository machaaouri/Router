using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    [ServiceContract]
    public interface IService
    {
        /*
         * return the Winner from each and every year for the UEFA Champions League since 1955;
        */

        [OperationContractAttribute(Action = "http://UEFA/champWinner", ReplyAction = "http://UEFA/champWinnerRespone")]
        String ChampWinner(long year);
    }
}
