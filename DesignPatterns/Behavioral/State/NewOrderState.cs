
namespace DesignPatterns.Behavioral.State
{
    public class NewOrderState : IOrderState
    {
        public void DeliverOrder(OrderContext context)
        {
            throw new NotImplementedException();
        }

        public void ProcessOrder(OrderContext context)
        {
            Console.WriteLine("[State] Order is being processed.");
            context.SetState(new ProcessingOrderState());
        }

        public void ShipOrder(OrderContext context)
        {
            Console.WriteLine("[State] Cannot deliver the order. Process and ship the order first.");
        }
    }
}
