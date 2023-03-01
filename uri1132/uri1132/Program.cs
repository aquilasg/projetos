using System;

class URI
{

    static void Main(string[] args)
    {

        int x, y, menor, maior, i, soma = 0;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            menor = y;
            maior = x;
        }
        else
        {
            menor = x;
            maior = y;
        }

        for (i = menor; i <= maior; i++)
        {
            if (i % 13 != 0)
            {
                soma = soma + i;
            }
        }

        Console.WriteLine(soma);

    }

}