using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._101Hack41
{
    class AriasLoops
    {
        static void ariasLoops(String[] args)
        {
            int[] firstLine = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = firstLine[0];
            int k = firstLine[1];
            //C(n - C(k - 1, 2), k);
            //C(n - a, k);
            double a = Math.Pow(k - 1, k - 0.5) / (Math.Pow(2, 2.5) * Math.Pow(k - 3, k - 5 / 2) * Math.Sqrt(2 * Math.PI));
            double b = Math.Pow(n - a, n - a + 0.5) / (Math.Pow(k, k + 0.5) * Math.Pow(n - a - k, n - a - k + 0.5) * Math.Sqrt(2 * Math.PI));
            Console.WriteLine((int)b % (7 + Math.Pow(10, 9)));
        }
    }
}
