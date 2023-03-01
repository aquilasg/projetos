using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int T, PA, PB, crescA, crescB, anos, i;
        double G1, G2;

        T = int.Parse(Console.ReadLine());

        for (i = 1; i <= T; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            PA = int.Parse(vet[0]);
            PB = int.Parse(vet[1]);
            G1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            G2 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            crescA = PA;
            crescB = PB;

            anos = 0;

            while (crescA <= crescB)
            {
                crescA += (int)(crescA * G1 / 100.0);
                crescB += (int)(crescB * G2 / 100.0);
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