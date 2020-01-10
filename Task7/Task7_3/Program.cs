using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringWords = "Иван: ivan@mail.ru, Петр: p_ivanov@mail.rol.ru";
            Regex regexp = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            MatchCollection matches = regexp.Matches(stringWords);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            Console.ReadKey();
        }
    }
}
