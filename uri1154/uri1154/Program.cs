using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int idade, soma = 0;
        double media = 0;

        idade = int.Parse(Console.ReadLine());

        while (idade >= 0)
        {
            media = media + 1;
            soma = soma + idade;
            idade = int.Parse(Console.ReadLine());
        }

        Console.WriteLine((soma/media).ToString("F2", CultureInfo.InvariantCulture));

    }

}