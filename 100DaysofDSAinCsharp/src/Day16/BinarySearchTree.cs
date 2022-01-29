namespace _100DaysofDSAinCsharp.src.Day16
{
    public class BinarySearchTree
    {
        //Instantiatite a root node;
        public TreeNode root;

        public BinarySearchTree()
        {
            //Initialise root node as null
            root = null;
        }

        /// <summary>
        /// Insert takes temproot i.e the root of the BST and value of the node to be created
        /// </summary>
        /// <param name="tempRoot"></param>
        /// <param name="e"></param>
        public void InsertIterative(TreeNode tempRoot, int e)
        {
            //Create a temporary node tohis will eventually be the where the new node will be linked to
            TreeNode temp = null;

            //Until the given root node is not null
            //iterate over to find the position where the new node can be inserted
            while (tempRoot != null)
            {
                temp = tempRoot;
                //if root is empty return
                if (e == tempRoot.element) return;
                //if given element is less than the curreent element - move to left
                else if (e < tempRoot.element) tempRoot = tempRoot.left;
                //else move to right
                else if (e > tempRoot.element) tempRoot = tempRoot.right;
            }
            //At the end of while loop - we should have the node where the new node will be inserted

            //create a new node with given value
            TreeNode newNode = new TreeNode(e, null, null);

            //Edgae case - if root is null - make the new node the root
            if (root == null) root = newNode;
            else
            {
                //if element is less than current element - make hte new node the left node else right
                if (e < temp.element) temp.left = newNode;
                else temp.right = newNode;
            }
        }

        /// <summary>
        /// Insert takes temproot i.e the root of the BST and value of the node to be created
        /// </summary>
        /// <param name="tempRoot"></param>
        /// <param name="e"></param>
        public TreeNode InsertRecursive(TreeNode tempRoot, int e)
        {
            //Create a temporary node tohis will eventually be the where the new node will be linked to
            TreeNode temp = null;

            //Until the given root node is not null
            //iterate over to find the position where the new node can be inserted
            if (tempRoot != null)
            {
                temp = tempRoot;
                if (e < tempRoot.element) tempRoot.left = InsertRecursive(tempRoot.left, e);

                else if (e > tempRoot.element) tempRoot.right = InsertRecursive(tempRoot.right, e);


            }
            else
            {
                //At the end of while loop - we should have the node where the new node will be inserted

                //create a new node with given value
                TreeNode newNode = new TreeNode(e, null, null);

                tempRoot = newNode;
            }

            return tempRoot;

        }

        public void InOrder(TreeNode tempRoot)
        {
            if (tempRoot == null) return;
            InOrder(tempRoot.left);
            System.Console.Write(tempRoot.element + " ");
            InOrder(tempRoot.right);
        }
        public void PreOrder(TreeNode tempRoot)
        {
            if (tempRoot == null) return;
            System.Console.Write(tempRoot.element + " ");
            PreOrder(tempRoot.left);
            PreOrder(tempRoot.right);
        }

        public void PostOrder(TreeNode tempRoot)
        {
            if (tempRoot == null) return;
            PostOrder(tempRoot.left);
            PostOrder(tempRoot.right);
            System.Console.Write(tempRoot.element + " ");
        }

        public bool SearchIterative(int e)
        {
            var tempRoot = root;
            while (tempRoot != null)
            {
                if (tempRoot.element == e) return true;
                else if (e < tempRoot.element) tempRoot = tempRoot.left;
                else if (e > tempRoot.element) tempRoot = tempRoot.right;

            }

            return false;
        }

        public bool SearchRecursive(TreeNode tempRoot, int e)
        {
            if (tempRoot == null) return false;
            if (tempRoot.element == e) return true;
            else if (e < tempRoot.element) return SearchRecursive(tempRoot.left, e);
            else if (e > tempRoot.element) return SearchRecursive(tempRoot.right, e);
            return false;
        }
    }
}
