using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = Math.PI;

            string value;

            do
            {
                Console.WriteLine("Enter Pi to the Nth digit");
                Console.WriteLine("Limit is 15");
                value = Console.ReadLine();
            } while (isDigitOnly(value) == false);

            if (Convert.ToInt16(value) >= 15)
            {
                Console.WriteLine(Math.Round(Pi, Convert.ToInt16(15)));
            }
            else
            {
                Console.WriteLine(Math.Round(Pi, Convert.ToInt16(value)));
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
