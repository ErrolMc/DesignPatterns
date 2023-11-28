
namespace DesignPatterns.Behavioral.State
{
    public class DeliveredOrderState : IOrderState
    {
        public void ProcessOrder(OrderContext context)
        {
            Console.WriteLine("[State] Cannot process the order. Order has already been delivered.");
        }

        public void ShipOrder(OrderContext context)
        {
            Console.WriteLine("[State] Cannot ship the order. Order has already been delivered.");
        }

        public void DeliverOrder(OrderContext context)
        {
            Console.WriteLine("[State] Order has already been delivered. Thank you!");
        }
    }
}
