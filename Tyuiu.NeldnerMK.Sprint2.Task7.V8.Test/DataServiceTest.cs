using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint2.Task7.V8.Lib;

namespace Tyuiu.NeldnerMK.Sprint2.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompare()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;

            bool res = true;
            Assert.AreEqual(res, ds.CheckDotInShadedArea(x,y));
        }
    }
}