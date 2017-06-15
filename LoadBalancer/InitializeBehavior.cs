using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace LoadBalancer
{
    class InitializeBehavior : BehaviorExtensionElement, IServiceBehavior
    {
        public InitializeBehavior()
        {

        }
        void IServiceBehavior.AddBindingParameters(ServiceDescription serviceDescription,
             ServiceHostBase serviceHostBase,
             System.Collections.ObjectModel.Collection<ServiceEndpoint> endpoints,
             BindingParameterCollection bindingParameters)
        {

        }

        void IServiceBehavior.ApplyDispatchBehavior(
             ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            Initialize initialize = new Initialize();
            serviceHostBase.Extensions.Add(initialize);

           
            
        }

        void IServiceBehavior.Validate(ServiceDescription serviceDescription,
                                       ServiceHostBase serviceHostBase)
        {
           
        }

        public override Type BehaviorType
        {
            get { return typeof(InitializeBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new InitializeBehavior();
        }

    }
}
