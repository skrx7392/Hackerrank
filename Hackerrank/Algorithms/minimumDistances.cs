using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms
{
    class minimumDistances
    {
        static void MinimumDistances(String[] args)
        {
            int size = int.Parse(Console.ReadLine());
            String[] nums = Console.ReadLine().Split(' ');
            int[] numbers = new int[size];
            int[] sortedNumbers = new int[size];
            for (int i=0; i<size; i++)
            {
                numbers[i] = int.Parse(nums[i]);
                sortedNumbers[i] = int.Parse(nums[i]);
            }
            List<int> repeatedNumbers = new List<int>();
            Array.Sort(sortedNumbers);
            for(int i=0; i<size-1; i++)
            {
                if(sortedNumbers[i]==sortedNumbers[i+1])
                {
                    if(!repeatedNumbers.Contains(sortedNumbers[i]))
                    {
                        repeatedNumbers.Add(sortedNumbers[i]);
                    }
                }
            }
            if(repeatedNumbers.Count==0)
            {
                Console.WriteLine(-1);
                return;
            }
            int minDistance = size + 1;
            foreach(int num in repeatedNumbers)
            {
                List<int> indices = new List<int>();
                for(int i=0; i<numbers.Length; i++)
                {
                    if(numbers[i]==num)
                    {
                        indices.Add(i);
                    }
                }
                for(int i=0; i<indices.Count-1; i++)
                {
                    minDistance = Math.Min(minDistance, indices[i+1] - indices[i]);
                }
            }
            Console.WriteLine(minDistance);
        }
    }
}
