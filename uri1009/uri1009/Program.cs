using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string vendedor;
        double salarioFixo, vendas, total;

        vendedor = Console.ReadLine();
        salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        total = salarioFixo + (vendas * 0.15);

        Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

    }

}