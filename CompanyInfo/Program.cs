using System;

namespace CompanyInfo
{
    class Program
    {
        static void Main()
        {
            string name = (Console.ReadLine());
            string address = Console.ReadLine();
            string phone = Console.ReadLine();
            string fax = (Console.ReadLine());
            string web = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            sbyte age = sbyte.Parse(Console.ReadLine());
            string managerphone = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Tel. " + phone);
            if (fax == string.Empty)
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: " + fax);
            }
            Console.WriteLine("Web site: " + web);
            Console.WriteLine("Manager: " + firstName + " " + lastName + " (age: " + age + ", tel. " + managerphone + ")");
        }
    }
}
