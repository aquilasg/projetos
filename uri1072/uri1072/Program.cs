using System;

class URI
{

    static void Main(string[] args)
    {

        int n, x, cont_in = 0, cont_out = 0, i;

        n = int.Parse(Console.ReadLine());

        for (i = 0; i < n; i++)
        {
            x = int.Parse(Console.ReadLine());
            if (x >= 10 && x <= 20)
            {
                cont_in = cont_in + 1;
            }
            else
            {
                cont_out = cont_out + 1;
            }
        }

        Console.WriteLine(cont_in + " in");
        Console.WriteLine(cont_out + " out");

    }

}