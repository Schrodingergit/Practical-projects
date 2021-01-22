using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//failed to do alone
namespace Fibonacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");

            string counter;

            counter = Console.ReadLine();

            for (int i = 0; i < Convert.ToInt16(counter); i++)
            {
                Console.WriteLine(Fibonacci(Convert.ToInt16(i)));
            }
             
        }

        public static int Fibonacci (int counter)
        {
            int f = 0;
            int f1 = 1;

            for (int i = 0; i < Convert.ToInt16(counter); i++)
            {
                int temp = f;
                f = f1;
                f1 = temp + f1;
            }
            return f;
        }
    }
}
