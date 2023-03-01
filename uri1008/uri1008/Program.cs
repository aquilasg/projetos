using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int number, hours;
        double value, salary;

        number = int.Parse(Console.ReadLine());
        hours = int.Parse(Console.ReadLine());
        value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salary = value * hours;

        Console.WriteLine("NUMBER = " + number);
        Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));

    }

}