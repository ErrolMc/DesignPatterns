
namespace DesignPatterns.Behavioral.Observer
{
    public class ObserverPatternRunner : PatternRunner
    {
        public override void Run()
        {
            Stock googleStock = new Stock("GOOGL", 1500.00);

            IInvestor investor1 = new StockInvestor("John");
            IInvestor investor2 = new StockInvestor("Alice");

            googleStock.RegisterInvestor(investor1);
            googleStock.RegisterInvestor(investor2);

            // Stock price changes
            googleStock.UpdatePrice(1525.50);
            googleStock.UpdatePrice(1518.75);

            // Investor2 is no longer interested
            googleStock.RemoveInvestor(investor2);

            // More stock price changes
            googleStock.UpdatePrice(1532.20);
        }
    }
}
