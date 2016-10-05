using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class RunningTimeAndComplexity
    {
        static void runningTimeAndComplexity(String[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int i=0; i<T; i++)
            {
                bool isPrime = true;
                int n = int.Parse(Console.ReadLine());
                if(n==1)
                {
                    isPrime = false;
                }
                for(int j=2; j<Math.Sqrt(n); j++)
                {
                    if(n%j==0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime");
                }
                else
                    Console.WriteLine("Not prime");
            }
        }
    }
}
