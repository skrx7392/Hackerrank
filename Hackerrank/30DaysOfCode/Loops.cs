using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class Loops
    {
        static void loops(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1; i<11; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
        }
    }
}
