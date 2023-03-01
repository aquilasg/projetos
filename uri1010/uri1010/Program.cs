using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] vet1 = Console.ReadLine().Split(' ');
        int peca1 = int.Parse(vet1[0]);
        int numPeca1 = int.Parse(vet1[1]);
        double valorUnit1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

        string[] vet2 = Console.ReadLine().Split(' ');
        int peca2 = int.Parse(vet2[0]);
        int numPeca2 = int.Parse(vet2[1]);
        double valorUnit2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

        double valorPagar;

        valorPagar = (numPeca1 * valorUnit1) + (numPeca2 * valorUnit2);

        Console.WriteLine("VALOR A PAGAR: R$ " + valorPagar.ToString("F2", CultureInfo.InvariantCulture));


    }

}