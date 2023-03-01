using System;

class URI
{

    static void Main(string[] args)
    {

        int n, i;

        n = int.Parse(Console.ReadLine());

        for (i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + "^2 = " + Math.Pow(i, 2));
            }
        }

    }

}