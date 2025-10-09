using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint2.Task1.V22.Lib;

namespace Tyuiu.NeldnerMK.Sprint2.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 324;
            int y = 696;
            int c = 254;
            int d = 155;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(x, y, c, d);
            bool[] wait1 = new bool[6] { true, true, true, false, false, false };

            CollectionAssert.AreEqual(wait1, res);

        }
    }
}