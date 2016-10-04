using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class Scope
    {
        static void scope(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }

    class Difference
    {
        private int[] elements;
        public int maximumDifference;
        public Difference(int[] a)
        {
            this.elements = a;
            maximumDifference = 0;
        }
        public void computeDifference()
        {
            Array.Sort(elements);
            maximumDifference = elements[elements.Length - 1] - elements[0];
        }
    }
}
