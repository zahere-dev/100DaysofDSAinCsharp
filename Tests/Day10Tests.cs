using _100DaysofDSAinCsharp.src.Day10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Day10Tests
    {
        [TestMethod]
        public void LruCacheTests()
        {


            LruCache lru = new LruCache(3);
            lru.put(1, 3);
            lru.put(2, 4);
            lru.put(3, 5);
            lru.put(4, 6);

            var res = lru.get(1);

            Assert.AreEqual(-1, res);


            LruCache lru2 = new LruCache(3);
            lru2.put(1, 3);
            lru2.put(1, 4);
            lru2.put(1, 5);
            lru2.put(1, 6);

            var res2 = lru2.get(1);

            Assert.AreEqual(6, res2);





        }
    }
}
