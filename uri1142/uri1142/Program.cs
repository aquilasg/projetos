using System;

class URI
{

    static void Main(string[] args)
    {

        int n, i, inicio = 1, segundo, terceiro;

        n = int.Parse(Console.ReadLine());

        for (i = 1; i <= n; i++)
        {
            segundo = inicio + 1;
            terceiro = inicio + 2;
            Console.WriteLine(inicio + " " + segundo + " " + terceiro + " PUM");

            inicio = inicio + 4;
        }
    }
}