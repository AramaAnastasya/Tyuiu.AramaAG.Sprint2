using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AramaAG.Sprint2.Task3.V2.Lib
{
    public class DataService : ISprint2Task3V2
    {
        public double Calculate(double x)
        {
            double rez = 0;
            if(x > 3)
            {
                rez = x - 12 * x + Math.Cos(x);
            }
            else
            {
                if (x == 2)
                {
                    rez = x - 1.0 / x;
                }
                else
                {
                    if (x < 1 && x > -6)
                    {
                        rez = Math.Pow(x, 5) + 10 * x - (1 / (Math.Sqrt(x + 3)));
                    }
                    else
                    {
                        if (x < -6)
                        {
                            rez = x + 10 * x - (1 / Math.Pow(x, 4));
                        }
                    }
                }

            }
            
            return Math.Round(rez, 3);
        }

    }
}
