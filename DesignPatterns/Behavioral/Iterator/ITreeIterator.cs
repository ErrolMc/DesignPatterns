
namespace DesignPatterns.Behavioral.Iterator
{
    // Iterator
    public interface ITreeIterator
    {
        TreeNode? Next();
        bool HasNext();
    }
}
