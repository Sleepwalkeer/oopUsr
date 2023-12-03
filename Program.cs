using oopUsr;
using System;

public class Client
{
    public static void Main()
    {
        Handler handler1 = new ConcreteHandler1();
        Handler handler2 = new ConcreteHandler2();
        Handler handler3 = new ConcreteHandler3();

        handler1.SetSuccessor(handler2);
        handler2.SetSuccessor(handler3);

        // Send requests to the chain
        handler1.HandleRequest(5);
        handler1.HandleRequest(15);
        handler1.HandleRequest(25);
    }
}