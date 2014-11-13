using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator aCalculator = new Calculator();
            double add=aCalculator.Add(20, 40);
            double mul= aCalculator.Multiply(40, 50);
            CalculatorExt.Multiply(aCalculator, 50, 60);

            Console.WriteLine(add+" "+mul);


            string aString = "A Labib";
            string TwoChaar = aString.GetFirstTwoCharacter();
            Console.WriteLine(TwoChaar);
            Console.ReadKey();

            int aint = 140;
            aint.IsBiggarThen100();
            PrimetiveExt.IsBiggarThen100(aint);
        }
    }
}
