using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SpirinAA.Sprint3.Task5.V25.Lib
{
    public class DataService : ISprint3Task5V25
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (j = startValue2; j <= stopValue2; j++)
                {
                    sumSeries = sumSeries + (Math.Pow(x, j) + Math.Cos(j)); 
                }
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
