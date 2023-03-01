using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double x1, y1, x2, y2, distancia;
        string[] vet;

        vet = Console.ReadLine().Split(' ');
        x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
        y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

        vet = Console.ReadLine().Split(' ');
        x2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
        y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

        
        distancia = Math.Sqrt(Math.Pow(x2-x1, 2.0) + Math.Pow(y2-y1, 2.0));

        Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

    }

}