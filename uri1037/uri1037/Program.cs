using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double valor, intervalo;

        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (valor >=0 && valor <= 25.00)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (valor > 25.00 && valor <= 50.00)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (valor > 50.00 && valor <= 75.00)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        else if (valor > 75.00 && valor <= 100.00)
        {
            Console.WriteLine("Intervalo (75,100]");
        }
        else
        {
            Console.WriteLine("Fora de intervalo");
        }

    }

}