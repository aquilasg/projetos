using System;

class URI
{

    static void Main(string[] args)
    {

        int x, soma;

        x = int.Parse(Console.ReadLine());

        while (x != 0)
        {
            // se for impar, some mais 1
            if (x % 2 != 0)
            {
                x = x + 1;
            }

            soma = x + (x + 2) + (x + 4) + (x + 6) + (x + 8);
            Console.WriteLine(soma);

            x = int.Parse(Console.ReadLine());

        }

    }

}