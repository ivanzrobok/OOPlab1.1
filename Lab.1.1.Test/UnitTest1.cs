using Lab1._1C_Sharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab._1._1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Time time = new Time();
            time.InIt(2, 30);
            Assert.AreEqual(150, time.Minutes());
        }
    }
}
