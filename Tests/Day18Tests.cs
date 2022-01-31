using _100DaysofDSAinCsharp.src.Day18;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day18Tests
    {
        [TestMethod]
        public void BSTTest()
        {
            BinarySearchTreeDay18 bTree = new BinarySearchTreeDay18();
            bTree.root = bTree.InsertRecursive(bTree.root, 50);
            bTree.InsertRecursive(bTree.root, 30);
            bTree.InsertRecursive(bTree.root, 80);
            bTree.InsertRecursive(bTree.root, 10);
            bTree.InsertRecursive(bTree.root, 40);
            bTree.InsertRecursive(bTree.root, 60);
            bTree.InsertRecursive(bTree.root, 90);
            System.Console.WriteLine($"Count of Nodes {bTree.Count(bTree.root)}");
            Assert.AreEqual(7, bTree.Count(bTree.root));
            Assert.AreEqual(3, bTree.GetHeight(bTree.root));
            System.Console.WriteLine($"Height {bTree.GetHeight(bTree.root)}");
            System.Console.WriteLine();
        }

    }
}
