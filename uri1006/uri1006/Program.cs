using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double A, B, C, MEDIA;

        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        MEDIA = ((A * 0.2) + (B * 0.3) + (C * 0.5));


        Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));

    }

}