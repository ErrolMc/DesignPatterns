

namespace DesignPatterns.Behavioral.Strategy
{
    // https://refactoring.guru/design-patterns/strategy
    public class StrategyPatternRunner : PatternRunner
    {
        public override void Run()
        {
            List<int> numbers = new List<int> { 7, 2, 5, 1, 9 };

            Sorter sorter = new Sorter(new BubbleSort());
            sorter.SortList(numbers);

            sorter.SetStrategy(new QuickSort());
            sorter.SortList(numbers);
        }
    }
}
