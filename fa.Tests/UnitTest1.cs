using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using fans;

namespace NET
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void FA1_Test1()
        {
            var fa = new FA1();
            Assert.IsTrue(fa.Run("10") == true);
        }

        [TestMethod]
        public void FA1_Test2()
        {
            var fa = new FA1();
            Assert.IsTrue(fa.Run("101") == true);
        }

        [TestMethod]
        public void FA1_Test3()
        {
            var fa = new FA1();
            Assert.IsTrue(fa.Run("1110") == true);
        }

        [TestMethod]
        public void FA1_Test4()
        {
            var fa = new FA1();
            Assert.IsTrue(fa.Run("0") == false);
        }

        [TestMethod]
        public void FA1_Test5()
        {
            var fa = new FA1();
            Assert.IsTrue(fa.Run("1001") == false);
        }

        [TestMethod]
        public void FA2_Test1()
        {
            var fa = new FA2();
            Assert.IsTrue(fa.Run("01") == true);
        }

        [TestMethod]
        public void FA2_Test2()
        {
            var fa = new FA2();
            Assert.IsTrue(fa.Run("011") == true);
        }

        [TestMethod]
        public void FA2_Test3()
        {
            var fa = new FA2();
            Assert.IsTrue(fa.Run("001") == false);
        }

        [TestMethod]
        public void FA2_Test4()
        {
            var fa = new FA2();
            Assert.IsTrue(fa.Run("0011") == false);
        }

        [TestMethod]
        public void FA2_Test5()
        {
            var fa = new FA2();
            Assert.IsTrue(fa.Run("111000") == true);
        }

        [TestMethod]
        public void FA3_Test1()
        {
            var fa = new FA3();
            Assert.IsTrue(fa.Run("11") == true);
        }

        [TestMethod]
        public void FA3_Test2()
        {
            var fa = new FA3();
            Assert.IsTrue(fa.Run("1011") == true);
        }

        [TestMethod]
        public void FA3_Test3()
        {
            var fa = new FA3();
            Assert.IsTrue(fa.Run("0101") == false);
        }
    }
}
