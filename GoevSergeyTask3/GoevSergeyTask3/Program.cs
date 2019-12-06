using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoevSergeyTask3
{
   

    class Program
    {
        static void PrintList(IEnumerable<int> list)
        {
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            bool delete = false;

            while(list.Count > 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (delete) list.RemoveAt(i--);
                    delete = !delete;
                }
                PrintList(list);
            }
 
            Console.ReadKey();
        }
    }
}
