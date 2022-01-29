using _100DaysofDSAinCsharp.src.Day15;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day15Tests
    {
        [TestMethod]
        public void TestIterative()
        {
            RecursionBasics.GetSquaresIterative(4);
        }

        [TestMethod]
        public void TestRecursive()
        {
            RecursionBasics.GetSquaresRecursive(4);
        }

    }
}
