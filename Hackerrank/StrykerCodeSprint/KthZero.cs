using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.StrykerCodeSprint
{
    class KthZero
    {
        static void kthZero(String[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            int n = int.Parse(line1[0]);
            int m = int.Parse(line1[1]);
            int[] line2 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            List<KeyValuePair<int, int>> numbers = new List<KeyValuePair<int, int>>();
            for(int i=0; i<line2.Length; i++)
            {
                numbers.Add(new KeyValuePair<int, int>(i, line2[i]));
            }
            numbers.Sort((x, y) => x.Value.CompareTo(y.Value));
            for (int i = 0; i < m; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                if(input[0] == 2)
                {
                    KeyValuePair<int, int> kvp = numbers.Find(x => x.Key == input[1]);
                    numbers.Remove(kvp);
                    KeyValuePair<int, int> newKvp = new KeyValuePair<int, int>(input[1], input[2]);
                    numbers.Add(newKvp);
                    numbers.Sort((x, y) => x.Value.CompareTo(y.Value));
                }
                else if(input[0]==1)
                {
                    try
                    {
                        if(numbers[input[1]-1].Value==0)
                        {
                            Console.WriteLine(numbers[input[1]-1].Key);
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
        }
    }
}
