using System;

class URI
{

    static void Main(string[] args)
    {

        int N, resto, nota, quociente;

        N = int.Parse(Console.ReadLine());
        Console.WriteLine(N);   

        resto = N;

        nota = 100;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
        resto = resto % nota;

        nota = 50;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
        resto = resto % nota;

        nota = 20;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
        resto = resto % nota;

        nota = 10;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
        resto = resto % nota;

        nota = 5;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
        resto = resto % nota;

        nota = 2;
        quociente = resto / nota;
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
        resto = resto % nota;

        Console.WriteLine(resto + " nota(s) de R$ 1,00");

    }

}