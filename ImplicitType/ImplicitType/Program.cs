using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitType
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var i = 50;
            var s = "Rocky";
            var d = 1.0;

            var numbers = new[] {10, 30, 60};

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();

        }
        
    }
}
