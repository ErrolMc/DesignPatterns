
namespace DesignPatterns.Behavioral.Observer
{
    // Observer
    public interface IInvestor
    {
        string Name { get; }
        void Update(string stockSymbol, double stockPrice);
    }
}
