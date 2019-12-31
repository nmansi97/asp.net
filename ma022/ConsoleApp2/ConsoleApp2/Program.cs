using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Calcarea
    {
        public double r;
        static double PI = 3.14;
        public double bh,h;
        public int l;
        public int b,s;
       public double area(double rr)
        {
            r = rr;
            return PI * (r * r);
           
        }
        public int area(int ll,int bb)
        {
            l = ll;
            b = bb;
           return  l * b;
          
        }
        public int area(int ss)
        {
            s = ss;
            return s * s;
           
        }
        public double area(double bb,double hh)
        {
            bh = bb;
            h = hh;
            return 0.5 * b * h;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Calcarea c = new Calcarea();
            Console.WriteLine("area of circle={0}", c.area(2.5));
            Console.WriteLine("area of rectangle={0}", c.area(2, 3));
            Console.WriteLine("area of square={0}", c.area(15));
            Console.WriteLine("area of triangle={0}", c.area(2.1, 2.1));
           
           

        }
    }
}
