using System;

class URI
{

    static void Main(string[] args)
    {

        int golInter = 0, golGremio = 0, novoGrenal = 1;
        int grenais = 0;
        int vitInter = 0, vitGremio = 0, empate = 0;

        while (novoGrenal == 1)
        {
            string[] vet = Console.ReadLine().Split(' ');
            golInter = int.Parse(vet[0]);
            golGremio = int.Parse(vet[1]);

            if (golInter == golGremio)
            {
                empate = empate + 1;
            }

            else if (golInter > golGremio)
            {
                vitInter = vitInter + 1;
            }
            else
            {
                vitGremio = vitGremio + 1;
            }

            grenais = grenais + 1;

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            novoGrenal = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(grenais + " grenais");
        Console.WriteLine("Inter:" + vitInter);
        Console.WriteLine("Gremio:" + vitGremio);
        Console.WriteLine("Empates:" + empate);

        if (vitInter > vitGremio)
        {
            Console.WriteLine("Inter venceu mais");
        }
        else
        {
            Console.WriteLine("Gremio venceu mais");
        }

    }

}