using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double A, B, C, tri, cir, tra, qua, ret, pi = 3.14159;

        string[] vet;
        vet = Console.ReadLine().Split(' ');
        A = double.Parse(vet[0], CultureInfo.InvariantCulture);
        B = double.Parse(vet[1], CultureInfo.InvariantCulture);
        C = double.Parse(vet[2], CultureInfo.InvariantCulture);

        tri = (A * C) / 2;
        cir = Math.Pow(C, 2) * pi;
        tra = (((A + B) * C) * 0.5);
        qua = (Math.Pow(B, 2));
        ret = A * B;

        Console.WriteLine("TRIANGULO: " + tri.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + cir.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + tra.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + qua.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + ret.ToString("F3", CultureInfo.InvariantCulture));

    }

}