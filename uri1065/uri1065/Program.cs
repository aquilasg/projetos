using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int n1, n2, n3, n4, n5, cont = 0;

        n1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n3 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n4 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n5 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (n1 % 2 == 0)
        {
            cont = cont + 1;
        }
        if (n2 % 2 == 0)
        {
            cont = cont + 1;
        }
        if (n3 % 2 == 0)
        {
            cont = cont + 1;
        }
        if (n4 % 2 == 0)
        {
            cont = cont + 1;
        }
        if (n5 % 2 == 0)
        {
            cont = cont + 1;
        }

        Console.WriteLine(cont + " valores pares");

    }

}