using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._101Hack41
{
    class LectureNotes
    {
        static void lectureNotes(String[] args)
        {
            int[] firstLine = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            string secondLine = Console.ReadLine();
            int[] thirdLine = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            bool tookNotes = false;
            foreach(int i in thirdLine)
            {
                if(secondLine[i-1] == 0)
                {
                    tookNotes = true;
                    break;
                }
            }
            if (tookNotes)
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
        }
    }
}
