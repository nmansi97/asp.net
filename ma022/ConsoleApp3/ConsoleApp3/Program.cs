using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Minmax
    {
        public int getmin(int [] arr,int size)
        {
            int m = 999;
            int i;
            for( i=0;i<size;i++)
            {
                if(arr[i]<m)
                {
                    m = arr[i];
                }
            
            }
            return m;
        }
        public int getmax(int [] arr,int size)
        {
            int mm = 0;
            int i;
            for(i=0;i<size;i++)
            {
                if(arr[i]>mm)
                {
                    mm = arr[i];
                }
            }
            return mm;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            int min,max;
            Minmax m1 = new Minmax();
            for(i=0;i<5;i++)
            {
                Console.Write("element{0}=", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("elements are...");
            for(i=0;i<5;i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }
            min = m1.getmin(arr, 5);
            Console.WriteLine("min value from array={0}", min);
            //   Console.WriteLine("hello");
            max = m1.getmax(arr, 5);
            Console.WriteLine("max value from array={0}", max);
        }
    }
}
