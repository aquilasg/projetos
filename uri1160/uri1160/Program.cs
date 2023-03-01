using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int t, pA, pB, crescA, crescB, i, anos;
        double g1, g2;

        t = int.Parse(Console.ReadLine());

        for (i = 1; i <= t; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            pA = int.Parse(vet[0]);
            pB = int.Parse(vet[1]);
            g1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            g2 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            crescA = pA;
            crescB = pB;

            anos = 0;

            while (crescA <= crescB)
            {
                crescA += (int)(crescA * (g1 / 100.0));
                crescB += (int)(crescB * (g2 / 100.0));
                anos += 1;
            }

            if (anos > 100)
            {
                Console.WriteLine("Mais de 1 seculo.");
            }
            else
            {
                Console.WriteLine(anos + " anos.");
            }
        }
    }
}