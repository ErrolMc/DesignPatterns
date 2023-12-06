
namespace DesignPatterns.Behavioral.Iterator
{
    // Concrete Iterator
    public class DepthFirstIterator : ITreeIterator
    {
        private Stack<TreeNode> stack = new Stack<TreeNode>();

        public DepthFirstIterator(TreeNode root)
        {
            InitializeStack(root);
        }

        private void InitializeStack(TreeNode node)
        {
            // push root node onto stack
            stack.Push(node);

            // push children in reverse order onto stack
            for (int i = node.Children.Count - 1; i >= 0; i--)
            {
                TreeNode child = node.Children[i];
                InitializeStack(child);
            }
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }

        public TreeNode? Next()
        {
            if (HasNext())
            {
                TreeNode node = stack.Pop();
                return node;
            }
            else
            {
                return null;
            }
        }
    }
}
