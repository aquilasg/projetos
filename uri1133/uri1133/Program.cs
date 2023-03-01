using System;

class URI
{

    static void Main(string[] args)
    {

        int x, y, aux, i;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x > y) //jeito diferente para classificar x e y como maior ou menor
        {
            aux = x;
            x = y;
            y = aux;
        }

        for (i = x + 1; i < y; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }

    }

}