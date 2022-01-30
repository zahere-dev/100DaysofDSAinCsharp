using _100DaysofDSAinCsharp.src.Day17;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day17Tests
    {
        [TestMethod]
        public void BSTTest()
        {
            BinarySearchTreeDay17 bTree = new BinarySearchTreeDay17();
            bTree.root = bTree.InsertRecursive(bTree.root, 50);
            bTree.InsertRecursive(bTree.root, 30);
            bTree.InsertRecursive(bTree.root, 80);
            bTree.InsertRecursive(bTree.root, 10);
            bTree.InsertRecursive(bTree.root, 40);
            bTree.InsertRecursive(bTree.root, 60);
            bTree.InsertRecursive(bTree.root, 90);
            bTree.InOrder(bTree.root);
            System.Console.WriteLine();
            bTree.Delete(60);
            bTree.InOrder(bTree.root);
            System.Console.WriteLine();
        }

    }
}
