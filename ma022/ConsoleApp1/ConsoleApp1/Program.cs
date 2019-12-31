using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[10];
            int i;
            int j;
          
            for(i=0;i<5;i++)
            {
                Console.Write("element-{0}:", i);
                arr[i]=Console.ReadLine();
            }
            Console.WriteLine("\n elements in an array are....");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }
            for(i=0;i<5;i++)
            {
                for(j=i+1;j<5;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        Console.WriteLine("duplicate string={0}",arr[i]);
                    }
                }
            }


        }
    }
}
