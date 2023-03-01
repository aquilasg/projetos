using System;

class URI
{

    static void Main(string[] args)
    {

        int i = 1, j;

        for (j = 60; j >= 0; j = j - 5)
        {
            Console.WriteLine("I=" + i + " " + "J=" + j);
            i = i + 3;
        }

    }

}