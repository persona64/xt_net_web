using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your number");

            string InputNumber = Console.ReadLine();
            double convertInt = Convert.ToDouble(InputNumber);

            if (convertInt % convertInt == 0 && convertInt % 1 == 0)
            {
                Console.WriteLine("The number " + convertInt + " is simple");
            }
            else
            {
                Console.WriteLine("The number " + convertInt + " is not simple");
            }
            Console.ReadLine();
        }
    }
}
