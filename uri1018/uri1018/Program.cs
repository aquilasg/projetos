using System;

class URI
{

    static void Main(string[] args)
    {

        uint N, cem, cin, vin, dez, cinq, dois, um, resto100, resto50, resto20, resto10, resto5, resto2, resto1;

        N = uint.Parse(Console.ReadLine());
        Console.WriteLine(N);

        cem = N / 100;
        Console.WriteLine(cem + " nota (s) de R$ 100,00");
        resto100 = N % 100;
        
        cinq = resto100 / 50;
        Console.WriteLine(cinq + " nota (s) de R$ 50,00");
        resto50 = resto100 % 50;

        vin = resto50 / 20;
        Console.WriteLine(vin + " nota (s) de R$ 20,00");
        resto20 = resto50 % 20;

        dez = resto20 / 10;
        Console.WriteLine(dez + " nota (s) de R$ 10,00");
        resto10 = resto20 % 10;

        cin = resto10 / 5;
        Console.WriteLine(cin + " nota (s) de R$ 5,00");
        resto5 = resto10 % 5;

        dois = resto5 / 2;
        Console.WriteLine(dois + " nota (s) de R$ 2,00");
        resto2 = resto5 % 2;

        um = resto2 / 1;
        Console.WriteLine(um + " nota (s) de R$ 1,00");

    }

}