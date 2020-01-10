using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task7_4
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void ValidationOfNumbers()
        {
            Console.WriteLine("Напишите число!");
            string inputString = Console.ReadLine();
            string regexp = @"\d{1}[e]{1}[-]{1}";

            if(Regex.IsMatch(inputString, regexp))
            {
                Console.WriteLine("Число написано в научной нотации");
            }
            else
            {
                int number = 0;
                bool attempt = int.TryParse(inputString, out number);

                if (attempt)
                {
                    Console.WriteLine("Число написано в обычной нотации");
                }
                else
                {
                    Console.WriteLine("Это не число!");
                }

            }
        }
    }
}
