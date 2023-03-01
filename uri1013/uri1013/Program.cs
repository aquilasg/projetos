using System;

class URI
{

    static void Main(string[] args)
    {

        int A, B, C, MaiorAB;

        string[] vet;

        vet = Console.ReadLine().Split(' ');
        A = int.Parse(vet[0]);
        B = int.Parse(vet[1]);
        C = int.Parse(vet[2]);

        if (A > B && A > C){
            Console.WriteLine(A + " eh o maior");
        }
        else if (B > A && B > C){
            Console.WriteLine(B + " eh o maior");
        }
        else if (C > A && C > B){
            Console.WriteLine(C + " eh o maior");
        }


    }

}