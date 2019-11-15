using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyGoevTask00Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your number");
            string InputNumber = Console.ReadLine();
            int converInt = Convert.ToInt32(InputNumber);

            Console.Write("Your number is " + converInt + ": ");

            for(int i = 0; i <= converInt; i++)
            { 
                if (i < converInt)
                {
                    Console.Write(i + ",");
                }
                else
                {
                    Console.Write(i + "");
                }
            }
            Console.ReadLine();
        }
    }
}
