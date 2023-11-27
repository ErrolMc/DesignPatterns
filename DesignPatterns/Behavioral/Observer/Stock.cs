
namespace DesignPatterns.Behavioral.Observer
{
    // Subject
    public class Stock
    {
        private List<IInvestor> investors;
        private string symbol;
        private double price;

        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
            investors = new List<IInvestor>();
        }

        public void RegisterInvestor(IInvestor investor)
        {
            if (investors.Contains(investor) == false)
            {
                investors.Add(investor);
                Console.WriteLine($"[Observer] Register investor {investor.Name}");
            }
        }

        public void RemoveInvestor(IInvestor investor)
        {
            if (investors.Contains(investor))
            {
                investors.Remove(investor);
                Console.WriteLine($"[Observer] Remove investor {investor.Name}");
            }
        }

        public void UpdatePrice(double newPrice)
        {
            if (newPrice != price)
            {
                price = newPrice;
                NotifyInvestors();
            }
        }

        private void NotifyInvestors()
        {
            foreach (IInvestor investor in investors)
            {
                investor.Update(symbol, price);
            }
        }
    }
}
