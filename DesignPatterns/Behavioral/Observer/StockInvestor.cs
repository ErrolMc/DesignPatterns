
namespace DesignPatterns.Behavioral.Observer
{
    // Concrete Observer
    public class StockInvestor : IInvestor
    {
        private string name;

        public StockInvestor(string name)
        {
            this.name = name;
        }

        public string Name => name;

        public void Update(string stockSymbol, double stockPrice)
        {
            Console.WriteLine($"[Observer] {name} received update for {stockSymbol} stock. New price: {stockPrice}");
        }
    }
}
