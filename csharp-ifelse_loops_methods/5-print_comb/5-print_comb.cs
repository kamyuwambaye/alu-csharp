using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 99; i++)
        {
            Console.Write("{0}{1:D2}", i == 0 ? "" : ", ", i);
        }
        Console.Write("\n");
    }
}
