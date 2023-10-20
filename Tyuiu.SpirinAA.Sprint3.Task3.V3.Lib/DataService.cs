using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SpirinAA.Sprint3.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0;

            foreach (char c in value)
            {
                if (c == 'f')
                {
                    count++;
                    if (count == 2)
                    {
                        break;
                    }
                }
            }
            return count;
        }
    }
}
