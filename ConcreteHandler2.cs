using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopUsr
{
    // ConcreteHandler2
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
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
