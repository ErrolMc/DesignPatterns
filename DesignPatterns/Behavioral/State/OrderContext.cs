
namespace DesignPatterns.Behavioral.State
{
    public class OrderContext
    {
        private IOrderState currentState;

        public OrderContext()
        {
            currentState = new NewOrderState();
        }

        public void ProcessOrder()
        {
            currentState.ProcessOrder(this);
        }

        public void ShipOrder()
        {
            currentState.ShipOrder(this);
        }

        public void DeliverOrder()
        {
            currentState.DeliverOrder(this);
        }

        public void SetState(IOrderState state)
        {
            currentState = state;
        }
    }
}
