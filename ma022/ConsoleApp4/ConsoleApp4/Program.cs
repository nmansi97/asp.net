using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[][,] arr = new int[][,]
            {
                new int[2,3] {{1,2,3},{4,5,6}},
                new int[3,2] {{10,11},{12,13},{14,15} },
                new int[2,3] {{0,1,2},{50,89,76}},
                new int[1,2] {{32,56}},
                new int[2,4] {{12,2,56,78},{45,78,10,3}},

            };
           for(i=0;i<arr.Length;i++)
            {
                for(j=0;j<arr[i].Length;j++)
                {
                    Console.WriteLine(arr[i][j] + "\t");
                }
            }
        }
    }
}
