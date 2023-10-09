using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint2.Task2.V15.Lib;

namespace Tyuiu.AramaAG.Sprint2.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 5;
            bool rez = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, rez);
        }
    }
}
