using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int n, i, x, y;
        double result;

        n = int.Parse(Console.ReadLine());

        for (i = 1; i <= n; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            if (y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                result = (double) x / y;
                Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }

}