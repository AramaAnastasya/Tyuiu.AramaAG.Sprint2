using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint2.Task7.V6.Lib;

namespace Tyuiu.AramaAG.Sprint2.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res); 
        }
    }
}
