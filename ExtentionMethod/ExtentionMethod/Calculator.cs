using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    class Calculator
    {
        public double FirstNo { get; set; }
        public double SecondNo { get; set; }

        public Calculator(double firstNo, double secondNo):this()
        {
            FirstNo = firstNo;
            SecondNo = secondNo;
        }

        public Calculator()
        {
        }

        public double Add(double firstNo, double secondNo)
        {
            return firstNo + secondNo;
        }

    }
}
