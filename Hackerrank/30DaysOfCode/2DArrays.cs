using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class _2DArrays
    {
        static void _2dArrays(String[] args)
        {
            int[][] matrix = new int[6][];
            for(int i=0; i<6; i++)
            {
                int[] row = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                matrix[i] = row;
            }
            List<int> sum = new List<int>();
            for(int i=0; i<4; i++)
            {
                for(int j=0; j<4; j++)
                {
                    sum.Add(matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2]
                        + matrix[i + 1][j + 1] + matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2]);
                }
            }
            sum.Sort();
            Console.WriteLine(sum.Last());
        }
    }
}
