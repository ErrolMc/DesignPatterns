
namespace DesignPatterns.Behavioral.State
{
    public class StatePatternRunner : PatternRunner
    {
        public override void Run()
        {
            OrderContext orderContext = new OrderContext();

            orderContext.ProcessOrder();
            orderContext.ShipOrder();
            orderContext.DeliverOrder();

            Console.WriteLine();

            orderContext.ProcessOrder();
            orderContext.ProcessOrder(); // Trying to process an already processed order
            orderContext.ShipOrder();
            orderContext.DeliverOrder();
            orderContext.ShipOrder(); // Trying to ship an already shipped order
        }
    }
}
