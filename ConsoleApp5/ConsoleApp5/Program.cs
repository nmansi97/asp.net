using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    interface rate
    {
        
        int getdays();
        double getkm();
    }
    abstract class car : rate
    {
      public  int carno;
       public  string name;
        abstract public void getcarinfo();
        public abstract int getdays();
        public abstract double getkm();
    }
    

    class customer : car
    {
        
        public override void getcarinfo()
        {
          
            Console.WriteLine("enter carno=");
            int carno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter carname=");
            string name = Console.ReadLine();

        }
        public override int getdays()
        {
            Console.WriteLine("enter days=");
            int days = Convert.ToInt32(Console.ReadLine());
            return days;
        }
        public override double getkm()
        {
            Console.WriteLine("enter kms=");
            double km = Convert.ToDouble(Console.ReadLine());
            return km;
        }
    
        public void calc_amt()
        {
            int d = getdays();
            double k = getkm();
            double rate_km = 7.5;
            int rate_Day = 500;
            double amt_kms = rate_km * k;
            double amt_days = rate_Day * d;
            Console.WriteLine("total kms="+ k);
            Console.WriteLine("total days="+d);
            Console.WriteLine("total amount based on kms=" + amt_kms);
            Console.WriteLine("total amount based on days=" + amt_days);
        }
       
        
       
    }
    class Program 
    {
        static void Main(string[] args)
        {
            customer c1 = new customer();
            c1.getcarinfo();
           
         
           
            c1.calc_amt();

        }
    }
}
