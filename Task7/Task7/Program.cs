using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "2016 гол наинается с 2016-01-01";
            Regex regexp = new Regex(@"\d{4}(-|\/)\d{2}\1\d{2}");

            MatchCollection matches = regexp.Matches(words);
            if(matches.Count > 0)
            {
                foreach(Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            Console.ReadKey();  
        }
    }
}
