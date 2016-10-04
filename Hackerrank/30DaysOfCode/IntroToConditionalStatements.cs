using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class IntroToConditionalStatements
    {
        static void introToConditionalStatements(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n%2==1)
            {
                Console.WriteLine("Weird");
                return;
            }
            if(n==2 || n==4)
            {
                Console.WriteLine("Not Weird");
                return;
            }
            if(n>5 && n<21)
            {
                Console.WriteLine("Weird");
                return;
            }
            if(n>20)
            {
                Console.WriteLine("Not Weird");
            }
            return;
        }
    }
}
