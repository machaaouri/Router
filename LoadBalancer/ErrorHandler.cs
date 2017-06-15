using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace LoadBalancer
{
    class ErrorHandler : IErrorHandler
    {
        public bool HandleError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void ProvideFault(Exception error, System.ServiceModel.Channels.MessageVersion version, ref System.ServiceModel.Channels.Message fault)
        {
            throw new NotImplementedException();
        }
    }
}
