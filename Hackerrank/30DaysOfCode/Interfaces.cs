using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class Interfaces
    {
        static void interfaces(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculators();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }

    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    class Calculators : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;
            for(int i=1; i<=n; i++)
            {
                if(n%i==0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
