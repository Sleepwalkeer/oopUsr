using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopUsr
{
    // ConcreteHandler1
    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >=0)
            {
                Console.WriteLine($"{GetType().Name} handles the request: {request}");
            }
            else 
            {
                successor.HandleRequest(request);
            }
        }
    }
}
