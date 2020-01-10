using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"В 7:55 я встал, позавтракал и к 10:77 пошёл на работу.";
            string pattern = @"(\s[0-9]{1}|\s[1]{1}[0-9]{1}|\s[2]{1}[0-3]{1}):[0-5]{1}[0-9]{1}\s";


            Regex regex = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
            MatchCollection matches = regex.Matches(str);

            Console.WriteLine("Время в тексте присутствует {0} раз.", matches.Count);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
            Console.ReadKey();
        }
    }
}
