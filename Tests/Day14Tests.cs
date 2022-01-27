using _100DaysofDSAinCsharp.src.Day14;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day14Tests
    {
        [TestMethod]
        public void Maximum_SubArraySum()
        {
            int[] nums = { 5, 4, -1, 7, 8 };

            var res = Maximum_Subarray_Sum_Kadanes_Algorithm.Find(nums);

            Assert.AreEqual(23, res);

        }

    }
}
