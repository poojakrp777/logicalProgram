using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class FibonacciSeries
    {
        public static void FindSeries(int n)
        {
            //Initilazing the variables
            int first = 0;
            int second = 1;
            int sum = 0;
            Console.Write("{0} {1}", first, second);
            //Starts the loop from 2 because 0 and 1 are already printed
            for (int i = 2; i < n; i++)
            {
                sum = first + second;
                Console.Write(" {0}", sum);
                first = second;
                second = sum;
            }
            Console.ReadLine();
        }
    }
}
