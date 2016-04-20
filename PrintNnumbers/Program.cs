using System;

namespace PrintNNumbers
{
    class PrintNNumbers
    {
        static void Main()
        {
            int n;
            bool isnInt = int.TryParse(Console.ReadLine(), out n);
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
        }
    }
}