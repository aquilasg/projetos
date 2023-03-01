using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int tempoGasto, veloMedia;
        double distancia, litros;

        tempoGasto = int.Parse(Console.ReadLine());
        veloMedia = int.Parse(Console.ReadLine());
        distancia = tempoGasto * veloMedia;
        litros = distancia / 12;


        Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
    }

}