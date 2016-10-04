using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class Sorting
    {
        public static void sorting(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int totalSwaps = 0;
            for(int i=0; i<n; i++)
            {
                int numberOfSwaps = 0;
                for(int j=0; j<n-1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        numberOfSwaps++;
                    }
                }
                totalSwaps += numberOfSwaps;
                if(numberOfSwaps == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Array is sorted in {0} swaps.", totalSwaps);
            Console.WriteLine("First Element: {0}", arr[0]);
            Console.WriteLine("Last Element: {0}", arr[arr.Length - 1]);
        }
    }
}
