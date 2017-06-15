using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace LoadBalancer
{
    class RoundRobin : IEnumerable<ServiceEndpoint>
    {
        public IEnumerator<ServiceEndpoint> GetEnumerator()
        {
            //TODO
            return null;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
