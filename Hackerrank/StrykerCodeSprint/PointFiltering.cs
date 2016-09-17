using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.StrykerCodeSprint
{
    class PointFiltering
    {
        static void Main(String[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            int n = int.Parse(line1[0]);
            int b = int.Parse(line1[1]);
            List<List<double>> points = new List<List<double>>();
            List<List<double>> bucket = new List<List<double>>();
            for(int i=0; i<n; i++)
            {
                points.Add(Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse).ToList());
            }
            points = points.OrderByDescending(x => x[3]).ToList();
            for(int i=0; i<b; i++)
            {
                List<double> point = points.First();
                points.RemoveAt(0);
                bucket.Add(point);
            }
            
            while(true)
            {
                string input = Console.ReadLine();
                if(String.IsNullOrEmpty(input))
                {
                    return;
                }
                string[] line = input.Split(' ');
                string c = line[0].ToUpper();
                int k = int.Parse(line[1]);
                List<double> point = bucket.Find(x => x[0] == k);
                if (String.Equals("F", c))
                {
                    if (point != null)
                    {
                        Console.WriteLine("{0} = ({1},{2},{3})", point[0], String.Format("{0:F3}", point[1]), String.Format("{0:F3}", point[2]), String.Format("{0:F3}", point[3]));
                    }
                    else
                        Console.WriteLine("Point doesn't exist in the bucket.");
                }
                else
                {
                    if(point==null)
                    {
                        Console.WriteLine("Point doesn't exist in the bucket.");
                    }
                    else
                    {
                        if(points.Count==0)
                        {
                            Console.WriteLine("No more points can be deleted.");
                        }
                        else
                        {
                            bucket.Remove(point);
                            Console.WriteLine("Point id {0} removed.", k);
                            List<double> anotherPoint = points.First();
                            bucket.Add(anotherPoint);
                            points.RemoveAt(0);
                        }
                    }
                }
            }
        }
    }
}
