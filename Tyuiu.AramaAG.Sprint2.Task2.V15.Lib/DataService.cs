using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AramaAG.Sprint2.Task2.V15.Lib
{
    public class DataService : ISprint2Task2V15
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool rez;
            if ((x == 2) && (4 < y && y < 7))
            {
                rez = true;
            }
            else if((x > 2 && x < 6) && (y  > 2 && y < 8))
            {
                rez = true;
            }
            else if((x > 8 && x < 13) && (y > 2 && y < 5))
            {
                rez = true;
            }
            else if((x > 5 && x < 13) && (y > 4 && y < 9))
            {
                rez = true;
            }
            else if(x == 13 && (y > 5 && y < 9))
            {
                rez = true;
            }
            else if((x > 4 && x < 7) && (y > 8 && y < 11))
            {
                rez = true;
            }
            else if(x == 6 && y == 11)
            {
                rez = true;
            }
            else if((x > 3 && x < 7) && y == 12)
            {
                rez = true;
            }
            else if((x > 1 && x < 4) && y == 13)
            {
                rez = true;
            }
            else if((x > 10 && x < 13) && (y > 8 && y < 12))
            {
                rez = true;
            }
            else if((x > 11 && x < 14) && y == 12)
            {
                rez = true;
            }
            else
            {
                rez = false;
            }
            return rez;
        }
    }
}
