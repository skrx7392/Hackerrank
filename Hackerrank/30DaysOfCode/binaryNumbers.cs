using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class BinaryNumbers
    {
        static void binaryNumbers(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            int maxCount = 0;
            int count = 0;
            bool prev = false;
            for(int i=0; i<binary.Length; i++)
            {
                if(binary[i] == '1')
                {
                    if(prev)
                    {
                        count++;
                        prev = true;
                        if(count>maxCount)
                        {
                            maxCount = count;
                        }
                    }
                    else
                    {
                        count = 1;
                        prev = true;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            Console.WriteLine(maxCount);
        }
    }
}
