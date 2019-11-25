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
            string WordString = "Skjnnf oiawfo jesef, oieff uei ihef kweubf uohdfb ilwhdu ucz";
            var Mas = WordString.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in Mas)
            {
                WordString += s.Length;
                Console.WriteLine("Средняя длина строки: {0}", WordString.Length/2);
            }
            

            Console.ReadLine();
        }
    }
}
