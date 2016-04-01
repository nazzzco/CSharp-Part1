using System;

namespace ReadAgeFromConsole
{
    class Program
    {
        static void Main()
        {
            DateTime date = DateTime.Today;

            string birthday = Console.ReadLine();
            int inputYear = int.Parse(birthday.Substring(6, 4));
            int inputMonth = int.Parse(birthday.Substring(0, 2));
            int age = date.Year - inputYear;
            if (inputMonth > date.Month)
            {
                age--;
            }

            int ageAfterTenYears = age + 10;

            Console.WriteLine(age);
            Console.WriteLine(ageAfterTenYears);

            //string input;
            //DateTime db;
            //Console.WriteLine("Enter your birth-date in this format(MM.DD.YYYY):");
            //input = Console.ReadLine();
            //db = Convert.ToDateTime(input);
            //Console.WriteLine("{0}.{1}.{2}", db.Month, db.Day, db.Year);
        }
    }
}
