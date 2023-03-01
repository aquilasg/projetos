using System;

class URI
{

    static void Main(string[] args)
    {

        int horaini, horafim, duracao;

        string[] vet = Console.ReadLine().Split(' ');
        horaini = int.Parse(vet[0]);
        horafim = int.Parse(vet[1]);

        if (horaini < horafim)
        {
            duracao = horafim- horaini;
        }
        else
        {
            duracao = 24 - horaini + horafim;
        }

        Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

    }

}