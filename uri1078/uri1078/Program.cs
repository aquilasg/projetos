using System;

class URI
{

    static void Main(string[] args)
    {

        int n, i, mult;

        n = int.Parse(Console.ReadLine());

        for (i = 1; i <= 10; i++)
        {
            if (n > 2 && n < 1000)
            {
                mult = i * n;
                Console.WriteLine(i + " x " + n + " = " + mult);
            }
        }

    }

}