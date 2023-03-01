using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double sal, novosal, reajuste, percentual;

        sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (sal <= 400.00)
        {
            percentual = 15.0;
        }
        else if (sal <= 800.00)
        {
            percentual = 12.0;
        }
        else if (sal <= 1200.00)
        {
            percentual = 10.0;
        }
        else if (sal <= 2000.00)
        {
            percentual = 7.0;
        }
        else
        {
            percentual = 4.0;
        }

        reajuste = sal * percentual / 100.0;
        novosal = reajuste + sal;


        Console.WriteLine("Novo salario: " + novosal.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: " + percentual + " %");
    }

}