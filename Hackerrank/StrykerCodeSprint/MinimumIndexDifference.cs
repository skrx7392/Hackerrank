using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.StrykerCodeSprint
{
    class MinimumIndexDifference
    {
        static void minimumIndexDifference(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');
            List<KeyValuePair<int, int>> arr1 = new List<KeyValuePair<int, int>>();
            List<KeyValuePair<int, int>> arr2 = new List<KeyValuePair<int, int>>();
            for(int i=0; i<n; i++)
            {
                arr1.Add(new KeyValuePair<int, int>(i, int.Parse(line1[i])));
                arr2.Add(new KeyValuePair<int, int>(i, int.Parse(line2[i])));
            }
            arr1 = arr1.OrderBy(x => x.Value).ToList();
            arr2 = arr2.OrderBy(x => x.Value).ToList();
            List<int[]> dupList = new List<int[]>();
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if(arr1[i].Value==arr2[j].Value)
                    {
                        dupList.Add(new int[] { arr1[i].Value, arr1[i].Key > arr2[j].Key ? arr1[i].Key - arr2[j].Key : arr2[j].Key - arr1[i].Key });
                    }
                    else if(arr2[j].Value>arr1[i].Value)
                    {
                        break;
                    }
                }
            }
            dupList = dupList.OrderBy(x => x[1]).ToList();
            Console.WriteLine(dupList[0][0]);
        }
    }
}
