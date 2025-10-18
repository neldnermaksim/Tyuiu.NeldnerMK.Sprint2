using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint2.Task4.V6.Lib;

namespace Tyuiu.NeldnerMK.Sprint2.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompare1()
        {
            DataService ds = new DataService();
            double x = 8;
            double y = 12;
            double res = ds.Calculate(x, y);
            double wait = 8.157;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidGetCompare2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 20;
            double res = ds.Calculate(x, y);
            double wait = 420.6;
            Assert.AreEqual(wait, res);

        }
    }
}
