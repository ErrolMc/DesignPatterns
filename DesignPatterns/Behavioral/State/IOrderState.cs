
namespace DesignPatterns.Behavioral.State
{
    // State
    public interface IOrderState
    {
        void ProcessOrder(OrderContext context);
        void ShipOrder(OrderContext context);
        void DeliverOrder(OrderContext context);
    }
}
