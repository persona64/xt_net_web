using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    class Comparing
    {
        public static bool Compare(int a, int b)
        {
            if (a > b)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool Compare(string first, string second)
        {
            var strOne = first.ToCharArray();
            var strTwo = second.ToCharArray();

            if (strOne.Length == strTwo.Length)
            {
                for (int i = 0; i < strOne.Length; i++)
                {
                    for (int j = 0; j < strTwo.Length; j++)
                    {
                        if (strOne != strTwo)
                        {
                            return strOne[i] < strTwo[j];
                        }
                    }
                }
                return false;
            }

            if (strOne.Length < strTwo.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
