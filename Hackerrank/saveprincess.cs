using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class saveprincess
    {
        static void displayPathtoPrincess(int n, char[][] grid)
        {
            n = n - 1;
            int[] myPos = findPosition('m', grid);
            int[] princessPosition = findPosition('p', grid);
            int horizontal = myPos[0] - princessPosition[0];
            int vertical = myPos[1] - princessPosition[1];
            string leftMovement = horizontal < 0 ? "LEFT" : "RIGHT";
            string upMovement = vertical > 0 ? "DOWN" : "UP";
            for(int i=0; i<Math.Abs(horizontal); i++)
            {
                Console.WriteLine(leftMovement);
            }
            for(int i=0; i<Math.Abs(vertical); i++)
            {
                Console.WriteLine(upMovement);
            }
        }

        static void start(String[] args)
        {
            int m;
            m = int.Parse(Console.ReadLine());

            char[][] grid = new char[m][];
            for (int i = 0; i < m; i++)
            {
                grid[i] = Console.ReadLine().ToCharArray();
            }

            displayPathtoPrincess(m, grid);
        }

        static int[] findPosition(char a, char[][] grid)
        {
            int[] coords = new int[2];
            for(int i=0; i<grid.Length; i++)
            {
                for(int j=0; j<grid[0].Length; j++)
                {
                    if(grid[i][j]==a)
                    {
                        coords[0] = i;
                        coords[1] = j;
                    }
                }
            }
            return coords;
        }

        static string[] romanizer(int[] numbers)
        {
            String[] result = new string[numbers.Length];
            Dictionary<int, String> dictionary = new Dictionary<int, string>();
            populateDictionary(dictionary);
            for(int i=0; i<numbers.Length; i++)
            {
                int number = numbers[i];
                string res = "";
                if (number == 1000)
                    result[i] = dictionary[number];
                else
                {
                    for (int count = 1; count < 4; count++)
                    {
                        int digit = number % ((int)Math.Pow(10,count));
                        if (digit > 0)
                        {
                            res = dictionary[digit] + res;
                            number = number - digit;
                        }
                    }
                    result[i] = res;
                }
            }
            return result;
        }

        static void populateDictionary(Dictionary<int, String> dictionary)
        {
            dictionary.Add(1, "I");
            dictionary.Add(2, "II");
            dictionary.Add(3, "III");
            dictionary.Add(4, "IV");
            dictionary.Add(5, "V");
            dictionary.Add(6, "VI");
            dictionary.Add(7, "VII");
            dictionary.Add(8, "VIII");
            dictionary.Add(9, "IX");
            dictionary.Add(10, "X");
            dictionary.Add(20, "XX");
            dictionary.Add(30, "XXX");
            dictionary.Add(40, "XL");
            dictionary.Add(50, "L");
            dictionary.Add(60, "LX");
            dictionary.Add(70, "LXX");
            dictionary.Add(80, "LXXX");
            dictionary.Add(90, "XC");
            dictionary.Add(100, "C");
            dictionary.Add(200, "CC");
            dictionary.Add(300, "CCC");
            dictionary.Add(400, "CD");
            dictionary.Add(500, "D");
            dictionary.Add(600, "DC");
            dictionary.Add(700, "DCC");
            dictionary.Add(800, "DCCC");
            dictionary.Add(900, "CM");
            dictionary.Add(1000, "M");
        }
    }
}
