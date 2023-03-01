using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        double A, B, MEDIA;

        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        MEDIA = (A * ((0.35 * 10) / 11)) + (B * ((0.75 * 10) / 11));
        Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));


    }

}