using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.StrykerCodeSprint
{
    class HiddenMessage
    {
        static void hiddenMessage(String[] args)
        {
            string t = Console.ReadLine();
            string p1 = Console.ReadLine();
            string[] p = p1.Split(' ');
            List<List<string>> matches = new List<List<string>>();
            int j = 0;
            int i = 0;
            while(i<p.Length)
            {
                int startPos = -1;
                int endPos = -1;
                    int k = 0;
                    while(k<p[i].Length && j<t.Length)
                    {
                        if(p[i][k] == t[j])
                        {
                            if(startPos<0)
                            {
                                startPos = j;
                                if(p[i].Length==1)
                                {
                                    endPos = j;
                                    matches.Add(new List<string> { p[i], startPos.ToString(), endPos.ToString() });
                                    break;
                                }
                            }
                            k++;
                            j++;
                        }
                        else if(p[i][k]!=t[j] && p[i].Length == j-startPos)
                        {
                            if(startPos>=0)
                            {
                                endPos = j - 1;
                                matches.Add(new List<string> { p[i], startPos.ToString(), endPos.ToString() });
                                break;
                            }
                            else
                            {
                                j++;
                            }
                        }
                        if(k==p[i].Length-1 && startPos>=0 && endPos<0)
                        {
                            endPos = j;
                            matches.Add(new List<string> { p[i], startPos.ToString(), endPos.ToString() });
                            break;
                        }
                    }
                    i++;
                    j = startPos + 1;
            }
            if (matches.Count == p.Length)
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
            if (matches.Count == 0)
            {
                Console.WriteLine("0");
                Console.WriteLine("0");
            }
            else
            {
                if(matches.Count<p.Length)
                {
                    foreach(var elem in matches)
                    {
                        Console.Write("{0} {1} {2} ", elem[0], elem[1], elem[2]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("0");
                }
                else
                {
                    int rep = 0;
                    for(int a=0; a<matches.Count; a++)
                    {
                        Console.Write("{0} {1} {2} ", matches[a][0], matches[a][1], matches[a][2]);
                        if(a!=0 && int.Parse(matches[a][1]) < int.Parse(matches[a-1][2]))
                        {
                            rep = rep + int.Parse(matches[a - 1][2]) - int.Parse(matches[a][1]) + 1;
                        }
                    }
                    Console.WriteLine();
                    int total = t.Length - p1.Length + 2*rep + 2*(p.Length - 1);
                    Console.WriteLine(total);
                }
            }
        }
    }
}
