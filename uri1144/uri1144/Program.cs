using System;

class URI
{

    static void Main(string[] args)
    {

        int n, i, n2, n3;

        n = int.Parse(Console.ReadLine());

        if (n > 1 && n < 1000)
        {
            for (i = 1; i <= n; i++)
            {
                n2 = i * i;
                n3 = i * i * i;
                Console.WriteLine(i + " " + n2 + " " + n3);
                Console.WriteLine(i + " " + (n2 + 1) + " " + (n3 + 1));
            }
        }
    }
}