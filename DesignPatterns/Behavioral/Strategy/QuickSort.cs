
namespace DesignPatterns.Behavioral.Strategy
{
    // Concrete Strategy
    public class QuickSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("[Strategy] Sorting using Quick Sort");
            // implementation of quick sort
        }
    }
}
