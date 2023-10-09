using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint2.Task3.V2.Lib;

namespace Tyuiu.AramaAG.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspression1()
        {
            DataService ds = new DataService();
            double x = 4.0;
            double rez = ds.Calculate(x);
            Assert.AreEqual(-44.654, rez);
        }
        [TestMethod]
        public void ValidExspression2()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double rez = ds.Calculate(x);
            Assert.AreEqual(1.5, rez);
        }
        [TestMethod]
        public void ValidExspression3()
        {
            DataService ds = new DataService();
            double x = 0;
            double rez = ds.Calculate(x);
            Assert.AreEqual(-0.577, rez);
        }
        [TestMethod]
        public void ValidExspression4()
        {
            DataService ds = new DataService();
            double x = -7.5;
            double rez = ds.Calculate(x);
            Assert.AreEqual(-82.5, rez);
        }
    }
}
