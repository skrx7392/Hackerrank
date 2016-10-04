using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class Exceptions
    {
        static void exceptions(String[] args)
        {
            string str = Console.ReadLine();
            try
            {
                int n = int.Parse(str);
                Console.WriteLine(n);
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
