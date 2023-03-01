using System;

class URI
{

    static void Main(string[] args)
    {

        int n, i, n1 = 1, n2, n3;

        n = int.Parse(Console.ReadLine());

        if (n > 1 && n < 1000)
        {
            for (i = 1; i <= n; i++)
            {
                n1 = i;
                n2 = i * i;
                n3 = i * i * i;
                Console.WriteLine(n1 + " " + n2 + " " + n3);

            }
        }

    }

}