using System;

class Sequence
{
    static void Main()
    {
        for (long i = 2; i < 1002; i++) // to match the requirement perfectly it must be: (short i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}
