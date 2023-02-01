using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class ReverseNumber
    {
        public static int Reverse(int number)
        {
            int remainder = 0, reverse = 0;
            Console.WriteLine(number); //1234
            while (number != 0)
            {
                remainder = number % 10; //4 3 2 1
                reverse = (reverse * 10) + remainder; //4 43 432 4321
                number = number / 10; //123 12 1 0
            }
            Console.WriteLine("After reverse:{0}", reverse);

            return reverse;
        }
    }
}
