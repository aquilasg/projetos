using System;

class URI
{

    static void Main(string[] args)
    {

        int n, x, y, i, j, soma, cont;

        n = int.Parse(Console.ReadLine());

        for (i = 0; i < n; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            soma = 0;
            cont = 0;

            for (j = x; cont < y; j++)
            {
                if (j % 2 != 0)
                {
                    soma = soma + j;
                    cont = cont + 1;
                }
            }

            Console.WriteLine(soma);

        }
    }
}