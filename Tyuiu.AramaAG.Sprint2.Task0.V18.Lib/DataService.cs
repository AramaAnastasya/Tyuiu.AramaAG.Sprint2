using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AramaAG.Sprint2.Task0.V18.Lib
{
    public class DataService : ISprint2Task0V18
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] rez = new bool[6];
            rez[0] = x == y;
            rez[1] = x != y;
            rez[2] = x < y + 6000;
            rez[3] = x > y;
            rez[4] = x <= y + 6000;
            rez[5] = x >= y + 6000;
            return rez;
        }
    }
}
