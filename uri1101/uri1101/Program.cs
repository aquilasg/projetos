using System;

class URI
{

    static void Main(string[] args)
    {

        int m, n, aux, i, soma;

        string[] vet = Console.ReadLine().Split(' ');
        m = int.Parse(vet[0]);
        n = int.Parse(vet[1]);

        while (m > 0 && n > 0)
        {
            if (m > n)
            {
                aux = m;
                m = n;
                n = aux;
            }

            soma = 0;

            for (i = m; i <= n; i++)
            {
                soma = soma + i;
                Console.Write(i + " ");
            }
            Console.WriteLine("Sum=" + soma);

            vet = Console.ReadLine().Split(' ');
            m = int.Parse(vet[0]);
            n = int.Parse(vet[1]);
        }
    }
}