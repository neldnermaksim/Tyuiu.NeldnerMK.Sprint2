using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint2.Task2.V6.Lib;

namespace Tyuiu.NeldnerMK.Sprint2.Task2.V6.Test 
{ 
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VilidCheckodInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;

            bool res = ds.CheckDotInShadeArea(x,y);
            bool wait = true;

            Assert.AreEqual(wait,res);
        }
    } 
}