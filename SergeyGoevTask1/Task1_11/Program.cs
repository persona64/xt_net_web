using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_11
{
    class Program
    {
        private static int nextWord;

        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            var arrayOfStrings = inputString.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int averageLenght = inputString.Aggregate(0, (count, nextWord) => count += nextWord) / inputString.Length;

            Console.WriteLine("Средняя длина строки: {0}", averageLenght);

            Console.ReadLine();
        }
    }
}
