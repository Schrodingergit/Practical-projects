using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//failed to do alone
namespace E_to_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            const double E = Math.E;

            string value;

            do
            {
                Console.WriteLine("E to the Nth digit");
                Console.WriteLine("Enter N, Limit is 15");
                value = Console.ReadLine();
            } while (isDigitOnly(value) == false);

            if (Convert.ToInt16(value) >= 15)
            {
                Console.WriteLine(Math.Round(E,Convert.ToInt16(15)));
            }
            else
            {
                Console.WriteLine(Math.Round(E, Convert.ToInt16(value)));
            }
           
        }
        public static bool isDigitOnly(string value)
        {
            foreach (char c in value)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
