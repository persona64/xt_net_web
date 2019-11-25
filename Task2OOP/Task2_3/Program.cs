using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            User Oleg = new User("Oleg", "Bardanov", "Alekseevich", new DateTime(1983, 07, 21));
            User Andrey = new User("Андрей", "Гербес", "Сергеевич", new DateTime(1982, 01, 29));

            Console.WriteLine("Фамилия: " + Oleg.UserSurname);
            Console.WriteLine("Имя: " + Oleg.UserName);
            Console.WriteLine("Отчество: " + Oleg.UserFatherName);
            Console.WriteLine("Дата рождения: " + Oleg.UserBirthday);
            Console.WriteLine("Возраст: " + Oleg.GetAge());
            Console.WriteLine();
            Console.WriteLine("Фамилия: " + Andrey.UserSurname);
            Console.WriteLine("Имя: " + Andrey.UserName);
            Console.WriteLine("Отчество: " + Andrey.UserFatherName);
            Console.WriteLine("Дата рождения: " + Andrey.UserBirthday);
            Console.WriteLine("Возраст: " + Andrey.GetAge());
            Console.ReadLine();
        }

        class User
        {
            public string Name;
            public string Surname;
            public string FatherName;
            public DateTime YearOfBirdth;

            public string UserName { get { return Name; } set { Name = value; } }

            public string UserSurname { get { return Surname; } set { Surname = value; } }

            public string UserFatherName { get { return FatherName; } set { FatherName = value; } }

            public int UserAge { get { return GetAge(); } }
            public DateTime UserBirthday { get { return YearOfBirdth; } set { YearOfBirdth = value; } }
            void InitializeUser(string name, string surname, string fathername, DateTime birthday)
            {
                UserName = name;
                UserSurname = surname;
                UserFatherName = fathername;
                UserBirthday = birthday;
            }

            public int GetAge()
            {
                int CalculationAge = DateTime.Now.Year - UserBirthday.Year;
                if (YearOfBirdth.AddYears(CalculationAge) > DateTime.Now)
                    CalculationAge--;
                return CalculationAge;
            }

            public User(string Name, string Surname, string FatherName, DateTime YearOfBirdth)
            {
                InitializeUser(Name, Surname, FatherName, YearOfBirdth);
            }

        }
    }

}
