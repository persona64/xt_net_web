using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class IsPositive
    {
        public static bool Positive(string str)
        {
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (!Char.IsDigit(ch[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
