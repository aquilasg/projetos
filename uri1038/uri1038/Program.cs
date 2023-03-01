using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int cod, quant;
        double total;

        string[] vet = Console.ReadLine().Split(' ');
        cod = int.Parse(vet[0]);
        quant = int.Parse(vet[1]);

        if (cod == 1)
        {
            total = quant * 4.0;
        }
        else if (cod == 2)
        {
            total = quant * 4.5;
        }
        else if (cod == 3)
        {
            total = quant * 5.0;
        }
        else if (cod == 4)
        {
            total = quant * 2.0;
        }
        else
        {
            total = quant * 1.5;
        }

        Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }

}