using System;

class URI
{

    static void Main(string[] args)
    {

        int n, x, y, aux, i, j, soma;

        n = int.Parse(Console.ReadLine());

        for (i = 0; i < n; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            if (x > y)
            {
                aux = x;
                x = y;
                y = aux;
            }


            soma = 0;
            for (j = x + 1; j < y; j++)
            {
                if (j % 2 != 0)
                {
                    soma = soma + j;
                }
            }
            Console.WriteLine(soma);
        }
    }
}