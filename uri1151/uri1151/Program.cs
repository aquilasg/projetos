using System;

class URI
{

    static void Main(string[] args)
    {

        int n, i, a, b, aux;

        n = int.Parse(Console.ReadLine());
        a = 0;
        b = 1;

        if (n < 46)
        {
            for (i = 0; i < n; i = i + 1)
            {
                if (i == n - 1)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.Write(a + " ");
                }
                aux = b;
                b = a;
                a = aux + b;
            }
        }
    }
}