using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class Generics
    {
        static void generics(string[] args)
        {
            int[] vInt = new int[] { 1, 2, 3 };
            string[] vString = new string[] { "Hello", "World" };

            printArray<int>(vInt);
            printArray<string>(vString);
        }

        public static void printArray<T>(T[] a)
        {
            foreach (var elem in a)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
