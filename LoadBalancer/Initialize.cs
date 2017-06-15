using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Routing;
using System.Text;
using System.Threading.Tasks;

namespace LoadBalancer
{
    /*
     * Any Customize setup that is likely to be called during startup can be done in this class
     * Here i'm gonna just setup the routing table
     * 
    */

    class Initialize : IExtension<ServiceHostBase>, IDisposable
    {

        private ServiceHostBase owner;
        private RoutingConfiguration routerConfiguration;

        public void Attach(ServiceHostBase owner)
        {
            
        }

        public void Detach(ServiceHostBase owner)
        {

        }

        public void Dispose()
        {
            // nothing to dispose for the moment
        }

        private void SetUpRoutingTable()
        {
            try
            {
                this.routerConfiguration = new RoutingConfiguration();
                routerConfiguration.FilterTable.Clear();
                /*
                 *  Here i'm basically telling the Router to Apply RoundRobin algorithm for load balancing
                 *  
                */ 
                routerConfiguration.FilterTable.Add(new Filter("http://UEFA/champWinner"), new RoundRobin());
                routerConfiguration.RouteOnHeadersOnly = false;
                this.owner.Extensions.Find<RoutingExtension>().ApplyConfiguration(routerConfiguration);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
