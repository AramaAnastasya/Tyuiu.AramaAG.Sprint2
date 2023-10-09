using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint2.Task1.V14.Lib;

namespace Tyuiu.AramaAG.Sprint2.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspression()
        {
            DataService ds = new DataService();
            int a = 185;
            int b = 216;
            int c = 174;
            int d = 917;
            bool[] rez = ds.GetLogicOperations(a, b, c, d);
            bool[] rez2 = { false, true, true, true, true, false };
            CollectionAssert.AreEqual(rez2, rez);
        }
    }
}
