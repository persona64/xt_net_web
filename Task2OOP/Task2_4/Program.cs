using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_4
{
    class MyString
    {
        private char[] _arrayOfChars;

        public char this[int id]
        {
            set
            {
                _arrayOfChars[id] = value;
            }
            get
            {
                return _arrayOfChars[id];
            }
        }

        public MyString(char[] ArrayOfChars)
        {
            _arrayOfChars = ArrayOfChars;
        }

        public MyString()
        {
            _arrayOfChars = new char[0];
        }
        public char[] ToArray()
        {
            return _arrayOfChars;
        }

        public static MyString operator +(MyString Firststring, MyString SecondString)
        {
            List<char> list = new List<char>();
            list.AddRange(Firststring.ToArray());
            list.AddRange(SecondString.ToArray());
            return new MyString(list.ToArray());
        }

        public static bool operator!=(MyString FirstString, MyString SecondString)
        {
            return FirstString.GetHashCode() != SecondString.GetHashCode();
        }
        public static bool operator ==(MyString FirstString, MyString SecondString)
        {
            return !(FirstString != SecondString);
        }

        public int Searching(char a)
        {
            if (_arrayOfChars.Contains(a))
            {
                return Array.IndexOf(_arrayOfChars, a);
            }
            else
            {
                return -1;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            string res = "";
            foreach (var item in _arrayOfChars)
            {
                res += item;
            }
            return res;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyString firstString = new MyString(new char[] { 'H', 'e', 'l', 'l', 'o' });
            MyString secondString = new MyString(new char[] { 'W', 'o', 'r', 'l', 'd' });
            Console.WriteLine((firstString == secondString).ToString());
            Console.WriteLine((firstString != secondString).ToString());
            Console.WriteLine((firstString + secondString).ToString());
            Console.WriteLine((firstString.Searching('o').ToString()));
            Console.ReadKey();
        }
    }
}
