
namespace DesignPatterns.Behavioral.Iterator
{
    // Concrete Iterator
    public class BreadthFirstIterator : ITreeIterator
    {
        private Queue<TreeNode> queue = new Queue<TreeNode>();

        public BreadthFirstIterator(TreeNode root)
        {
            queue.Enqueue(root);
        }

        public bool HasNext()
        {
            return queue.Count > 0;
        }

        public TreeNode? Next()
        {
            if (HasNext())
            {
                TreeNode node = queue.Dequeue();

                // enqueue the children
                foreach (TreeNode child in node.Children)
                {
                    queue.Enqueue(child);
                }

                return node;
            }
            else
            {
                return null;
            }
        }
    }
}
