using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Job
    {
        static void job(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for(int i=0; i<n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int k = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            foreach(int i in numbers)
            {
                if(i<k)
                {
                    nums.Add(i);
                }
            }
            
            List<List<int>> finalList = new List<List<int>>();
            
            for(int i=1; ; i++)
            {
                List<int> sample = new List<int>();
                sample = nums;
                for(int j=1; ;  j++)
                {
                    var elem = sample.Take(i);
                    finalList.Add(elem.ToList());
                    if (sample.Count >= j)
                    {
                        sample.RemoveAt(0);
                    }
                    
                    else break;
                }
                if (nums.Count >= i)
                {
                    nums.RemoveAt(0);
                }
                else break;
            }

            int count = 0;
            foreach(var list in finalList)
            {
                int product = 1;
                for(int i=0; i<list.Count; i++)
                {
                    product = product * list[i];
                }
                if(product<k)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
