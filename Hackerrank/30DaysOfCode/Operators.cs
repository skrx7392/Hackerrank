using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class Operators
    {
        static void operators(String[] args)
        {
            double price = double.Parse(Console.ReadLine());
            int tip = int.Parse(Console.ReadLine());
            int tax = int.Parse(Console.ReadLine());
            int total = (int)Math.Round(price + (price * tip / 100) + (price * tax / 100));
            Console.WriteLine("The total meal cost is {0} dollars.", total);
        }
    }
}
