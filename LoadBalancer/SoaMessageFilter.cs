using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace LoadBalancer
{
    /*
     * this classis used to filter incoming requests
     */

    class Filter : MessageFilter
    {
        private string serviceContract;

        public Filter(String serviceContract)
        {
            this.serviceContract = serviceContract;
        }


        public override bool Match(System.ServiceModel.Channels.Message message)
        {
            return message.Headers.Action.Contains(serviceContract);
        }


        public override bool Match(System.ServiceModel.Channels.MessageBuffer buffer)
        {
            return Match(buffer.CreateMessage());
        }
    }
}
