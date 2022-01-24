using _100DaysofDSAinCsharp.src.Day13;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day13Tests
    {
        [TestMethod]
        public void FindDuplicateNumberTest()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 8, 9, 7, 6, 7 };
            Assert.AreEqual(7, FindTheDuplicateNumber.Find(nums));
        }


        [TestMethod]
        public void Sort1s2s()
        {
            int[] nums = new int[] { 1, 1, 0, 0, 1, 1, 2, 2, 0, 1 };
            Assert.AreEqual(0, SortArrayof1s2s.SortColors(nums)[0]);
        }
    }


}
