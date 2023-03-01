using System;

class URI
{

    static void Main(string[] args)
    {

        int maior, x, i, posicao = 1;

        maior = int.Parse(Console.ReadLine());


        for (i = 2; i <= 100; i++)
        {
            x = int.Parse(Console.ReadLine());
            if (x > maior)
            {
                maior = x;
                posicao = i;
            }
        }
        Console.WriteLine(maior);
        Console.WriteLine(posicao);

    }

}