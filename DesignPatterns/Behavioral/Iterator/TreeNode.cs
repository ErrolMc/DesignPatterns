
namespace DesignPatterns.Behavioral.Iterator
{
    public class TreeNode
    {
        public int Value { get; private set; }
        public List<TreeNode> Children { get; private set; }

        public TreeNode(int value)
        {
            Value = value;
            Children = new List<TreeNode>();
        }

        public void AddChild(TreeNode child)
        {
            Children.Add(child);
        }
    }
}
