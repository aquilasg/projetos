using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int distancia;
        double combustivelGasto, consumoMedio;

        distancia = int.Parse(Console.ReadLine());
        combustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        consumoMedio = distancia / combustivelGasto;


        Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
    }

}