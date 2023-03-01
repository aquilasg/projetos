using System;

class URI
{

    static void Main(string[] args)
    {

        int n, i;

        n = int.Parse(Console.ReadLine());

        for (i = 1; i <= 10000; i++)
        {
            if (n < 10000)
            {
                if (i % n == 2)
                {
                    Console.WriteLine(i);
                }
            }

        }

    }
}