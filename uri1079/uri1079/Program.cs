using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int n, i;

        double r1, r2, r3, media;

        n = int.Parse(Console.ReadLine());

        for (i = 0; i < n; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            r1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            r2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            r3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            media = (r1 * 0.2) + (r2 * 0.3) + (r3 * 0.5);

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }

}