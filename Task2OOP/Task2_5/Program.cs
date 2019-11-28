using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Cris = new Employee("Cris", "Henderson", "Mark", new DateTime(1994, 08, 21), new DateTime(2016, 06, 28), "Technical Engeneer");

            Console.WriteLine("Фамилия: " + Cris.UserSurname);
            Console.WriteLine("Имя: " + Cris.UserName);
            Console.WriteLine("Отчество: " + Cris.UserFatherName);
            Console.WriteLine("Дата рождения: " + Cris.UserBirthday);
            Console.WriteLine("Возраст: " + Cris.GetAge());
            Console.WriteLine("Дата принятия на работу: " + Cris.DateOfEmployment);
            Console.WriteLine("Стаж работы: " + Cris.GetExperience());
            Console.WriteLine("Занимаемая должность: " + Cris.positionOnWork);
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

        private class Employee : User
        {

            public DateTime DateOfEmployment; 
            public string PositionOnWork; 

            public DateTime dateOfEmployment { get { return DateOfEmployment; } set { DateOfEmployment = value; } }
            public string positionOnWork { get { return PositionOnWork; } set { PositionOnWork = value; } }
            void InitializeEmployee(DateTime dateofEmployment, string positiononWork)
            {
                DateOfEmployment = dateofEmployment;
                PositionOnWork = positiononWork;
            }

            public int GetExperience()
            {
                int CalculationExperience = DateTime.Now.Year - dateOfEmployment.Year;
                if (DateOfEmployment.AddYears(CalculationExperience) > DateTime.Now)
                    CalculationExperience--;
                return CalculationExperience;
            }
            public Employee(string Name, string Surname, string FatherName, DateTime YearOfBirdth, DateTime DateOfEmployment, string PositionOnWork) : base(Name, Surname, FatherName, YearOfBirdth)
            {
                InitializeEmployee(DateOfEmployment, PositionOnWork);
            }

        }
    }


}
