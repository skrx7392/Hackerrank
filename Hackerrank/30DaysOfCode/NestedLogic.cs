using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class NestedLogic
    {
        static void nestedLogic(String[] args)
        {
            int[] returnDate = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int[] dueDate = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int fine = 0;
            if (returnDate[2] > dueDate[2])
            {
                fine = 10000;
            }
            else if(returnDate[2]==dueDate[2])
            {
                if(returnDate[1]>dueDate[1])
                {
                    fine = 500 * (returnDate[1] - dueDate[1]);
                }
                else if(returnDate[1]==dueDate[1])
                {
                    if(returnDate[0]>dueDate[0])
                    {
                        fine = 15 * (returnDate[0] - dueDate[0]);
                    }
                }
            }
            Console.WriteLine(fine);
        }
    }
}
