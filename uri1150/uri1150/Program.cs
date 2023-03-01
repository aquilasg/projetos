using System;

class URI
{

    static void Main(string[] args)
    {

        int x, z, i, soma = 0, cont = 0;

        x = int.Parse(Console.ReadLine());
        z = int.Parse(Console.ReadLine());

        while (x >= z)
        {
            z = int.Parse(Console.ReadLine());
        }

        for (i = x; soma < z; i++)
        {
            soma = soma + i;
            cont = cont + 1;
        }
        Console.WriteLine(cont);
    }
}