using _100DaysofDSAinCsharp.src.Day16;

namespace _100DaysofDSAinCsharp.src.Day18
{
    public class BinarySearchTreeDay18 : BinarySearchTree
    {
        public int Count(TreeNode node)
        {
            if (node == null) return 0;
            int x = Count(node.left);
            int y = Count(node.right);
            return x + y + 1;
        }

        public int GetHeight(TreeNode node)
        {
            if (node == null) return 0;
            int x = GetHeight(node.left);
            int y = GetHeight(node.right);
            if (x > y) return x + 1;
            return y + 1;
        }

    }
}
