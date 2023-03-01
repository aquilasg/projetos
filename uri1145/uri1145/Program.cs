using System;

class URI
{

    static void Main(string[] args)
    {

        int x, y, i;

        string[] vet = Console.ReadLine().Split(' ');
        x = int.Parse(vet[0]);
        y = int.Parse(vet[1]);

        if ((x > 1 && x < 20) && (y > x && y < 100000))
        {
            for (i = 1; i <= y; i++)
            {
                Console.Write(i);
                if (i % x == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}