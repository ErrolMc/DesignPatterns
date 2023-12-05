
namespace DesignPatterns.Behavioral.Strategy
{
    // Context
    public class Sorter
    {
        private ISortStrategy sortStrategy;

        public Sorter(ISortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void SetStrategy(ISortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void SortList(List<int> list)
        {
            sortStrategy.Sort(list);
        }
    }
}
