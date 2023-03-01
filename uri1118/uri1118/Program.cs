using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double nota1, nota2, media;
        int novoCalculo = 1;

        while (novoCalculo == 1)
        {

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = (nota1 + nota2) / 2.0;

            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("novo calculo (1-sim 2-nao)");
            novoCalculo = int.Parse(Console.ReadLine());
            while (novoCalculo != 1 && novoCalculo != 2)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine());
            }

        }

    }

}