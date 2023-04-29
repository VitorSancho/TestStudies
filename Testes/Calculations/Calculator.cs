using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return b + a;
        }

        public double AddDouble(double a, double b)
        {
            return b + a;
        }

        public bool IdOdd(int value)
        {
            return (value % 2) == 1;
        }
    }
}
