using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class DictionariesAndMaps
    {
        static void dictionariesAndMaps(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            for(int i = 0; i<n; i++)
            {
                String[] arr = Console.ReadLine().Split(' ');
                phoneBook.Add(arr[0], arr[1]);
            }
            while (true)
            {
                String name = Console.ReadLine();
                if(String.IsNullOrEmpty(name))
                {
                    return;
                }
                if(phoneBook.ContainsKey(name))
                {
                    Console.WriteLine("{0}={1}", name, phoneBook[name]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
