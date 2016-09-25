using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.WorldCodeSprint7
{
    class TwoCharacters
    {
        static void twoCharacters(String[] args)
        {
            int len = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            List<char> charList = str.ToList();
            List<char> uniqueChars = new List<char>();
            foreach(char c in charList)
            {
                if(!uniqueChars.Contains(c))
                {
                    uniqueChars.Add(c);
                }
            }
            int maxLength = 0;
            for(int i=0; i<uniqueChars.Count; i++)
            {
                for(int j=0; j<uniqueChars.Count; j++)
                {
                    if (j != i)
                    {
                        List<char> newList = new List<char>(charList);
                        newList.RemoveAll(x => !(x == uniqueChars[i] || x == uniqueChars[j]));
                        bool output = true;
                        for (int k = 0; k < newList.Count - 1; k += 2)
                        {
                            if (newList[0] == uniqueChars[i])
                            {
                                if (!(newList[k] == uniqueChars[i] && newList[k + 1] == uniqueChars[j]))
                                {
                                    output = false;
                                    break;
                                }
                            }
                            else
                            {
                                if (!(newList[k] == uniqueChars[j] && newList[k + 1] == uniqueChars[i]))
                                {
                                    output = false;
                                    break;
                                }
                            }
                        }
                        if (output && maxLength < newList.Count)
                        {
                            maxLength = newList.Count;
                        }
                    }
                }
            }
            Console.WriteLine(maxLength);
        }
    }
}
