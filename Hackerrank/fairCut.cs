using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class fairCut
    {
        static void Main(String[] args)
        {
            String[] line1 = Console.ReadLine().Split(' ');
            int n = int.Parse(line1[0]);
            int k = int.Parse(line1[1]);
            String[] line2 = Console.ReadLine().Split(' ');
            int[] numbers = new int[n];
            for(int i=0; i<n; i++)
            {
                numbers[i] = int.Parse(line2[i]);
            }
            Array.Sort(numbers);

        }
    }
}
