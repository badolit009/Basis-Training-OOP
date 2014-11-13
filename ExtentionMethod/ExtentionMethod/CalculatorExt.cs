using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    static class CalculatorExt
    {
        public static double Multiply(this Calculator aCalculator, double firstNo, double secondNo)
        {
            return firstNo*secondNo;
        }
    }
}
