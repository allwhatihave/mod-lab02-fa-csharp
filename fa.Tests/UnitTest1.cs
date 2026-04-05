using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using fans;

namespace NET
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "0111";
            FA1 fa = new FA1();
            Assert.IsTrue(fa.Run(s) == true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string s = "01011";
            FA1 fa = new FA1();
            Assert.IsTrue(fa.Run(s) == false);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string s = "110101011";
            FA1 fa = new FA1();
            Assert.IsTrue(fa.Run(s) == false);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string s = "1110111";
            FA1 fa = new FA1();
            Assert.IsTrue(fa.Run(s) == true);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string s = "10";
            FA1 fa = new FA1();
            Assert.IsTrue(fa.Run(s) == true);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string s = "0101";
            FA2 fa = new FA2();
            Assert.IsTrue(fa.Run(s) == false);
        }

        [TestMethod]
        public void TestMethod7()
        {
            string s = "00110011";
            FA2 fa = new FA2();
            Assert.IsTrue(fa.Run(s) == false);
        }

        [TestMethod]
        public void TestMethod8()
        {
            string s = "0001";
            FA2 fa = new FA2();
            Assert.IsTrue(fa.Run(s) == true);
        }

        [TestMethod]
        public void TestMethod9()
        {
            string s = "111000";
            FA2 fa = new FA2();
            Assert.IsTrue(fa.Run(s) == true);
        }

        [TestMethod]
        public void TestMethod10()
        {
            string s = "00110011";
            FA3 fa = new FA3();
            Assert.IsTrue(fa.Run(s) == true);
        }

        [TestMethod]
        public void TestMethod11()
        {
            string s = "0101";
            FA3 fa = new FA3();
            Assert.IsTrue(fa.Run(s) == false);
        }

        [TestMethod]
        public void TestMethod12()
        {
            string s = "0";
            FA1 fa = new FA1();
            Assert.IsTrue(fa.Run(s) == false);
        }

        [TestMethod]
        public void TestMethod13()
        {
            string s = "1";
            FA1 fa = new FA1();
            Assert.IsTrue(fa.Run(s) == false);
        }

        [TestMethod]
        public void TestMethod14()
        {
            string s = "";
            FA1 fa = new FA1();
            Assert.IsTrue(fa.Run(s) == false);
        }

        [TestMethod]
        public void TestMethod15()
        {
            string s = "01";
            FA2 fa = new FA2();
            Assert.IsTrue(fa.Run(s) == true);
        }

        [TestMethod]
        public void TestMethod16()
        {
            string s = "101001";
            FA2 fa = new FA2();
            Assert.IsTrue(fa.Run(s) == true);
        }

        [TestMethod]
        public void TestMethod17()
        {
            string s = "0011";
            FA2 fa = new FA2();
            Assert.IsTrue(fa.Run(s) == false);
        }

        [TestMethod]
        public void TestMethod18()
        {
            string s = "1111";
            FA2 fa = new FA2();
            Assert.IsTrue(fa.Run(s) == false);
        }

        [TestMethod]
        public void TestMethod19()
        {
            string s = "11";
            FA3 fa = new FA3();
            Assert.IsTrue(fa.Run(s) == true);
        }

        [TestMethod]
        public void TestMethod20()
        {
            string s = "";
            FA3 fa = new FA3();
            Assert.IsTrue(fa.Run(s) == false);
        }

        [TestMethod]
        public void TestMethod21()
        {
            string s = "0000";
            FA3 fa = new FA3();
            Assert.IsTrue(fa.Run(s) == false);
        }
    }
}
