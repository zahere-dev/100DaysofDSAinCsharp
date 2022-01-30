using _100DaysofDSAinCsharp.src.Day16;

namespace _100DaysofDSAinCsharp.src.Day17
{
    public class BinarySearchTreeDay17 : BinarySearchTree
    {
        public bool Delete(int e)
        {
            //set a temporarory root node
            TreeNode p = root;

            //Reference of parent of parent
            TreeNode pp = null;

            while (p != null && p.element != e)
            {
                //capture reference of previous or parent of parent
                pp = p;
                if (e < p.element) p = p.left;
                else p = p.right;
            }

            if (p == null) return false;

            if (p.left != null && p.right != null)
            {
                TreeNode s = p.left;
                TreeNode ps = p;

                while (s.right != null)
                {
                    ps = s;
                    s = s.right;
                }
                p.element = s.element;
                p = s;
                pp = ps;

            }
            TreeNode c = null;
            if (p.left != null) c = p.left;
            else c = p.right;

            if (p == root) root = null;
            else
            {
                if (p == pp.left) pp.left = c;
                else pp.right = c;
            }
            return true;

        }

    }
}
