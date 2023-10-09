using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.AramaAG.Sprint2.Task1.V14.Lib
{
    public class DataService : ISprint2Task1V14
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] rez = new bool[6];
            rez[0] = a == b | c > d;
            rez[1] = a < b & d > c;
            rez[2] = a >= c || b <= d;
            rez[3] = a != b && c < d;
            rez[4] = !(c > a);
            rez[5] = (a < b) ^ (c <= b);
            return rez;
        }
    }
}
