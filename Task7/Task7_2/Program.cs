using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Task7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tegs = "<b>Это</b> текст <i>с</i> <fontcolor='red'>HTML</font> кодами";

            Console.WriteLine(Regex.Replace(tegs, @"<[^>]*>", "_"));
            Console.ReadKey();
        }
    }
}
