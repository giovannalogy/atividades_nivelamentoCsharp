using System;

class Program
{
    static void Main ()
    {
        int dentroIntervalo = 0;
        int foraIntervalo = 0;

        Console.WriteLine("Informe a quantidade de valores para o programa ler: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Insira o valor " + (i + 1) + ":");
            int X = int.Parse(Console.ReadLine());

            if (X >= 10 && X <= 20)
            {
                dentroIntervalo++;
            }
            else
            {
                foraIntervalo++;
            }

        }

        Console.WriteLine(dentroIntervalo + " in");
        Console.WriteLine(foraIntervalo + " out");

    }
}