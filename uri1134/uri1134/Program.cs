using System;

class URI
{

    static void Main(string[] args)
    {

        int n, contAlcool = 0, contGaso = 0, contDiesel = 0;

        n = int.Parse(Console.ReadLine());

        while (n != 4)
        {
            if (n == 1)
            {
                contAlcool = contAlcool + 1;
            }
            else if (n == 2)
            {
                contGaso = contGaso + 1;
            }
            else if (n == 3)
            {
                contDiesel = contDiesel + 1;
            }

            n = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + contAlcool);
        Console.WriteLine("Gasolina: " + contGaso);
        Console.WriteLine("Diesel: " + contDiesel);

    }

}