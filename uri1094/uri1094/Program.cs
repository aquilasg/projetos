using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int i, n, quantia, coelhos = 0, ratos = 0, sapos = 0, total = 0;
        string cobaia;
        double percentCoelhos, percentRatos, percentSapos;

        n = int.Parse(Console.ReadLine());

        for (i = 1; i <= n; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            quantia = int.Parse(vet[0]);
            cobaia = (vet[1]);

            if (cobaia == "C")
            {
                coelhos = coelhos + quantia;
            }
            else if (cobaia == "R")
            {
                ratos = ratos + quantia;
            }
            else
            {
                sapos = sapos + quantia;
            }
        }

        total = coelhos + ratos + sapos;
        percentCoelhos = (coelhos * 100.0) / total;
        percentRatos = (ratos * 100.0) / total;
        percentSapos = (sapos * 100.0) / total;

        Console.WriteLine("Total: " + total + " cobaias");
        Console.WriteLine("Total de coelhos: " + coelhos);
        Console.WriteLine("Total de ratos: " + ratos);
        Console.WriteLine("Total de sapos: " + sapos);
        Console.WriteLine("Percentual de coelhos: " + percentCoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        Console.WriteLine("Percentual de ratos: " + percentRatos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        Console.WriteLine("Percentual de sapos: " + percentSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");
    }
}