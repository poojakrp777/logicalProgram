using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from below options");
            Console.WriteLine("1:Fibonacciseries\n2.Perfect Number\n3.Prime Number\n4.Reverse Number\n5.Coupun Number\n6.Stop Watch");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    int n = Convert.ToInt32(Console.ReadLine());
                    FibonacciSeries.FindSeries(n);
                    break;
                case 2:
                    PerfectNo Perfect_No = new PerfectNo();
                    Perfect_No.PerfectNumber();
                    break;
                case 3:
                    PrimeNumber.FindPrimes();
                    break;
<<<<<<< HEAD
                case 4:
                    Console.WriteLine("Enter any number to find reverse");
                    int number = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.Reverse(number);
                    break;
                case 5:
                    CouponNumber.Coupon();
                    break;
=======
                //case 4:
                //    Console.WriteLine("Enter any number to find reverse");
                //    int number = Convert.ToInt32(Console.ReadLine());
                //    ReverseNumber.Reverse(number);
                //    break;
                //case 5:
                //    CouponNumber.Coupon();
                //    break;
>>>>>>> 3.PrimeNo
            }
            Console.ReadLine();
        }
    }
}
