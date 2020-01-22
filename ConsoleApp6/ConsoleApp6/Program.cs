using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp6
{
    class Program
    {
        public static void calltochildthread()
        {
            try
            {
                Console.WriteLine("child thread starts...");
                for (int c = 0; c <= 10; c++)
                {
                    Thread.Sleep(200);
                    Console.WriteLine(c);
                }
                Console.WriteLine("child thread completed...");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("thread abort exception");
            }
        }
        public static void calltochildthread2()
        {
            try
            {
                Console.WriteLine("child thread starts...");
                for (char i = 'a'; i <= 'j'; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(i);
                }
                Console.WriteLine("child thread completed...");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("thread abort exception");
            }
        }
        static void Main(string[] args)
        {
            ThreadStart child1 = new ThreadStart(calltochildthread);
            Console.WriteLine("creaing the child thread:");
            Thread childthread = new Thread(child1);
            childthread.Start();
          
            ThreadStart child2 = new ThreadStart(calltochildthread2);
            Console.WriteLine("creaing the child thread:");
            Thread childthread2 = new Thread(child2);
            childthread2.Start();
            Thread.Sleep(1000);
            Thread.Sleep(2000);
            Console.WriteLine("In Main: Aborting the Child thread");
            childthread.Abort();


        }
    }
}
