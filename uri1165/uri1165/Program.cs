using System;

class URI
{

    static void Main(string[] args)
    {

        int n, x, i, metade, j;
        bool primo;

        n = int.Parse(Console.ReadLine());

        for (i = 0; i < n; i++)
        {
            x = int.Parse(Console.ReadLine());
            metade = x / 2;

            primo = true;

            for (j = 2; j <= metade; j++)
            {
                if (x % j == 0)
                {
                    primo = false;
                    break;
                }
            }

            if (primo)
            {
                Console.WriteLine(x + " eh primo");
            }
            else
            {
                Console.WriteLine(x + " nao eh primo");
            }
        }
    }
}