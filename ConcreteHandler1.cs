using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopUsr
{
    // ConcreteHandler1
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine($"{GetType().Name} handles the request: {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
