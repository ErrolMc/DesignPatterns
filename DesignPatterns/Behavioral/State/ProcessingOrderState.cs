
namespace DesignPatterns.Behavioral.State
{
    public class ProcessingOrderState : IOrderState
    {
        public void ProcessOrder(OrderContext context)
        {
            Console.WriteLine("[State] Order is already being processed.");
        }

        public void ShipOrder(OrderContext context)
        {
            Console.WriteLine("[State] Order is being shipped.");
            context.SetState(new ShippedOrderState());
        }

        public void DeliverOrder(OrderContext context)
        {
            Console.WriteLine("[State] Cannot deliver the order. Ship the order first.");
        }
    }
}
