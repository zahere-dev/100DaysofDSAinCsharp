using _100DaysofDSAinCsharp.src.Day19;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day19Tests
    {
        [TestMethod]
        public void BSTTest()
        {

            //Assert.AreEqual(0, NthFibonacci.Run(0));
            Assert.AreEqual(1, NthFibonacci.Run(2));
            Assert.AreEqual(5, NthFibonacci.Run(6));


        }

    }
}
