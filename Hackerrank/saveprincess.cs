using System;
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

        //static void Main(String[] args)
        //{
        //    int m;
        //    m = int.Parse(Console.ReadLine());

        //    char[][] grid = new char[m][];
        //    for(int i=0;i<m; i++)
        //    {
        //        grid[i] = Console.ReadLine().ToCharArray();
        //    }

        //    displayPathtoPrincess(m, grid);
        //}

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
    }
}
