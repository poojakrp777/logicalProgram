using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PrimeNumber
    {
        public static void FindPrimes()
        {
            int flag = 0;
            Console.WriteLine("Enter the Number to check Prime: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is Prime.");
        }
    }
}
