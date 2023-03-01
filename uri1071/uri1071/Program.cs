using System;

class URI
{

    static void Main(string[] args)
    {

        int x, y, menor, maior, i, soma = 0;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x < y)
        {
            menor = x;
            maior = y;
        }
        else
        {
            menor = y;
            maior = x;
        }

        for (i = menor + 1; i < maior; i++)
        {
            if (i % 2 != 0)
            {
                soma = soma + i;
            }
        }

        Console.WriteLine(soma);
    }

}