using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Implementation
{
    public class GradingStudents
    {
        public void Start()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[n];
            for (int grades_i = 0; grades_i < n; grades_i++)
            {
                grades[grades_i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = Solve(grades);
            Console.WriteLine(String.Join("\n", result));
        }

        private int[] Solve(int[] grades)
        {
            var result = new int[grades.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < 38)
                {
                    result[i] = grades[i];
                }
                else if ((grades[i] % 5) > 2)
                {
                    result[i] = grades[i] + (5 - grades[i] % 5);
                }
                else
                {
                    result[i] = grades[i];
                }
            }
            return result;
        }
    }
}
