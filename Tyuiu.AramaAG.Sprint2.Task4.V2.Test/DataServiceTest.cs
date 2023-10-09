using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint2.Task4.V2.Lib;

namespace Tyuiu.AramaAG.Sprint2.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspression1()
        {
            DataService ds = new DataService();
            double x = 9.5;
            double y = 5.5;
            double rez = ds.Calculate(x, y);
            Assert.AreEqual(11.409, rez);
        }
        [TestMethod]
        public void ValidExspression2()
        {
            DataService ds = new DataService();
            double x = 2.1;
            double y = 1.5;
            double rez = ds.Calculate(x, y);
            Assert.AreEqual(1.857, rez);
        }
    }
}
