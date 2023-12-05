
namespace DesignPatterns.Behavioral.Strategy
{
    // Concrete Strategy
    public class BubbleSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("[Strategy] Sorting using Bubble Sort");
            // implementation of bubble sort
        }
    }
}
