using System;

class URI
{

    static void Main(string[] args)
    {

        int n;

        n = int.Parse(Console.ReadLine());

        if (n == 61)
        {
            Console.WriteLine("Brasilia");
        }
        else if (n == 71)
        {
            Console.WriteLine("Salvador");
        }
        else if (n == 11)
        {
            Console.WriteLine("Sao Paulo");
        }
        else if (n == 21)
        {
            Console.WriteLine("Rio de Janeiro");
        }
        else if (n == 32)
        {
            Console.WriteLine("Juiz de Fora");
        }
        else if (n == 19)
        {
            Console.WriteLine("Campinas");
        }
        else if (n == 27)
        {
            Console.WriteLine("Vitoria");
        }
        else if (n == 31)
        {
            Console.WriteLine("Belo Horizonte");
        }
        else
        {
            Console.WriteLine("DDD nao cadastrado");
        }

    }

}