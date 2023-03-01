using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double R, volume, pi = 3.14159, R3;

        R = double.Parse(Console.ReadLine());
        R3 = Math.Pow(R, 3.0);

        volume = ((4 / 3.0) * pi * R3);

        /** Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens
        (dentre elas o C++), assumem que o resultado da divisão entre dois inteiros é outro inteiro. */

        Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
    }

}