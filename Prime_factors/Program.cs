using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Done it with algorithm from internet
namespace Prime_factors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find all Prime factors");

            int value = Int32.Parse(Console.ReadLine());

            value = Convert.ToInt32(value);

            int prime = 2;

            Console.WriteLine($"Prime factor of {value}");

            PrimeFactorization(value, prime);
        }

        public static int PrimeFactorization(int value, int prime)
        {

            while (value >= prime * prime)
            {
                if (value % prime == 0)
                {
                    Console.Write(prime + "*");
                    value /= prime;
                }
                else
                {
                    prime += 1;
                }
            }
            Console.WriteLine(value);
            return value;
        }
    }
}
