
namespace DesignPatterns.Behavioral.Iterator
{
    public class IteratorPatternRunner : PatternRunner
    {
        public override void Run()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node2 = new TreeNode(2);
            TreeNode node3 = new TreeNode(3);
            TreeNode node4 = new TreeNode(4);
            TreeNode node5 = new TreeNode(5);

            root.AddChild(node2);
            root.AddChild(node3);
            node3.AddChild(node4);
            node3.AddChild(node5);

            // Use DFS iterator
            Console.WriteLine("[Iterator] Depth-First Search:");
            ITreeIterator dfsIterator = new DepthFirstIterator(root);
            while (dfsIterator.HasNext())
            {
                TreeNode? node = dfsIterator.Next();
                if (node != null)
                    Console.Write($"{node.Value} ");
            }

            Console.WriteLine();

            // Use BFS iterator
            Console.WriteLine("[Iterator] Breadth-First Search:");
            ITreeIterator bfsIterator = new BreadthFirstIterator(root);
            while (bfsIterator.HasNext())
            {
                TreeNode? node = bfsIterator.Next();
                if (node != null)
                    Console.Write($"{node.Value} ");
            }
        }
    }
}
