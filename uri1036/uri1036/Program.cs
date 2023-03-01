using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        /** ax2 + bx + c = 0
         * x = -b +- raíz de delta / (2*a)
         * delta = b2 - 4*a*c
         * delta não pode ser negativo
         * a não pode ser zero
         */

        double a, b, c, delta, r1, r2;

        string[] vet = Console.ReadLine().Split(' ');
        a = double.Parse(vet[0], CultureInfo.InvariantCulture);
        b = double.Parse(vet[1], CultureInfo.InvariantCulture);
        c = double.Parse(vet[2], CultureInfo.InvariantCulture);

        delta = Math.Pow(b, 2.0) - 4 * a * c;

        if (delta < 0 || a == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            r1 = ((-b) + Math.Sqrt(delta)) / (2.0 * a);
            r2 = ((-b) - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));

        }
    }

}