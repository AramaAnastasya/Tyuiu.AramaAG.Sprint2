using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint2.Task0.V18.Lib;


namespace Tyuiu.AramaAG.Sprint2.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspression()
        {
            DataService ds = new DataService();
            int x = 5105;
            int y = 475;
            bool[] rez = ds.GetCompareOperations(x, y);
            bool[] rez2 = { false, true, true, true, true, false };
            CollectionAssert.AreEqual(rez2, rez);
        }
    }
}
