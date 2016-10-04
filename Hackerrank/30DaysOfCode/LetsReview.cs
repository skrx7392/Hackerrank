using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class LetsReview
    {
        static void letsReview(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                string str = Console.ReadLine();
                for(int j=0; j<str.Length; j = j+2)
                {
                    Console.Write(str[j]);
                }
                Console.Write(" ");
                for(int j=1; j<str.Length; j+=2)
                {
                    Console.Write(str[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
