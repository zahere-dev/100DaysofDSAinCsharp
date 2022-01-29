using _100DaysofDSAinCsharp.src.Day16;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day16Tests
    {
        [TestMethod]
        public void BinarySearchTreeTests()
        {
            BinarySearchTree bTree = new BinarySearchTree();
            //bTree.InsertIterative(bTree.root, 50);
            //bTree.InsertIterative(bTree.root, 30);
            //bTree.InsertIterative(bTree.root, 80);
            //bTree.InsertIterative(bTree.root, 10);
            //bTree.InsertIterative(bTree.root, 40);
            //bTree.InsertIterative(bTree.root, 60);
            //bTree.InsertIterative(bTree.root, 90);
            //bTree.InOrder(bTree.root);


            bTree.root = bTree.InsertRecursive(bTree.root, 50);
            bTree.InsertRecursive(bTree.root, 30);
            bTree.InsertRecursive(bTree.root, 80);
            bTree.InsertRecursive(bTree.root, 10);
            bTree.InsertRecursive(bTree.root, 40);
            bTree.InsertRecursive(bTree.root, 60);
            bTree.InsertRecursive(bTree.root, 90);
            bTree.InOrder(bTree.root);
            System.Console.WriteLine();
            bTree.PreOrder(bTree.root);
            System.Console.WriteLine();
            bTree.PostOrder(bTree.root);
            System.Console.WriteLine();
            System.Console.WriteLine($"Found 60 {bTree.SearchIterative(60)}");
            System.Console.WriteLine($"Found 110 {bTree.SearchIterative(110)}");
            System.Console.WriteLine($"Found 60 {bTree.SearchRecursive(bTree.root, 60)}");
            System.Console.WriteLine($"Found 110 {bTree.SearchRecursive(bTree.root, 110)}");

        }
    }
}
