using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 9; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                Console.Write("{0}{1}{2}", (i == 0 && j == 1) ? "" : ", ", i, j);
            }
        }
        Console.Write("\n");
    }
}
