using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class Recursion
    {
        static void recursion(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(factorial(n));
        }

        static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
                return n*factorial(n - 1);
        }
    }
}
