using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class repeatedString
    {
        /// <summary>
        /// Rename RepeatedString to Main to run the function. This was part of hourrank 12 challenge in hackerrank.
        /// </summary>
        /// <param name="args"></param>
        static void RepeatedString(String[] args)
        {
            string s = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());
            long count = 0;
            char[] schar = s.ToCharArray();
            int[] locator = new int[schar.Length];
            long div = n / s.Length;
            long rem = n % s.Length;
            int remCount = 0;
            for (int i=0; i<s.Length; i++)
            {
                if (schar[i] == 'a')
                {
                    count++;
                    locator[i] = 1;
                    if(i<rem)
                    {
                        remCount++;
                    }
                }
                else
                    locator[i] = 0;
            }
            count = div * count + remCount;
            Console.WriteLine(count);
        }
    }
}
