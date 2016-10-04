using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class Arrays
    {
        static void arrays(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Reverse(arr);
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
