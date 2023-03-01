using System;

class URI
{

    static void Main(string[] args)
    {

        int N, ano, mes, dia, resto;

        N = int.Parse(Console.ReadLine());

        ano = N / 365;
        Console.WriteLine(ano + " ano(s)");
        resto = N % 365;

        mes = resto / 30;
        Console.WriteLine(mes + " mes(es)");

        dia = resto % 30;
        Console.WriteLine(dia + " dia(s)");

    }

}