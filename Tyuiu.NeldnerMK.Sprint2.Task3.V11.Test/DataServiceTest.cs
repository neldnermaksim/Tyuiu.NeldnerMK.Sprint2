using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint2.Task3.V11.Lib;

namespace Tyuiu.NeldnerMK.Sprint2.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateXGreaterThanZero()
        {
            DataService ds = new DataService();
            double x = 5;
            double res = ds.Calculate(x);
            double wait = ds.Calculate(x); 
            Assert.AreEqual(wait, res, 0.001); 
        }

        [TestMethod]
        public void ValidCalculateXEqualToZero()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 11; 
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculateXBetweenMinus15AndZero()
        {
            DataService ds = new DataService();
            double x = -5;
            double res = ds.Calculate(x);
            double wait = ds.Calculate(x); // Используем тот же метод
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculateXLessThanMinus15()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            double wait = -219.95; // -20 + 10*(-20) - (1/-20) = -20 -200 + 0.05 = -219.95
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}