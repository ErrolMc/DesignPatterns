
namespace DesignPatterns.Behavioral.State
{
    public class ShippedOrderState : IOrderState
    {
        public void ProcessOrder(OrderContext context)
        {
            Console.WriteLine("[State] Cannot process the order. Order has already been shipped.");
        }

        public void ShipOrder(OrderContext context)
        {
            Console.WriteLine("[State] Order is already shipped.");
        }

        public void DeliverOrder(OrderContext context)
        {
            Console.WriteLine("[State] Order is delivered. Thank you!");
            context.SetState(new DeliveredOrderState());
        }
    }
}
