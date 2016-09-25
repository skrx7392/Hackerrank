using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.WorldCodeSprint7
{
    class GridlandMetro
    {
        static void Main(String[] args)
        {
            int[] line1 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int n = line1[0];
            int m = line1[1];
            Dictionary<int, List<int>> data = new Dictionary<int, List<int>>(); 
            for(int i=0; i<line1[2]; i++)
            {
                int[] line = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                if(!data.Keys.Contains(line[0]))
                {
                    data.Add(line[0], Enumerable.Range(line[1], line[2] - line[1] + 1).ToList());
                }
                else
                {
                    for(int j=line[1]; j<=line[2]; j++)
                    {
                        if(!data[line[0]].Contains(j))
                        {
                            data[line[0]].Add(j);
                        }
                    }
                }
            }
            int count = 0;
            foreach(int key in data.Keys)
            {
                count = count + data[key].Count;
            }
            Console.WriteLine(n*m - count);
         }
    }
}
