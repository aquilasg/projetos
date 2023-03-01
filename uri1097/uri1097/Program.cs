using System;

class URI
{
    static void Main(string[] args)
    {
        int i, j = 7;

        for (i = 1; i <= 9; i += 2)
        {
            Console.WriteLine("I=" + i + " J=" + j);
            Console.WriteLine("I=" + i + " J=" + (j - 1));
            Console.WriteLine("I=" + i + " J=" + (j - 2));
            j = j + 2;
        }
    }
}