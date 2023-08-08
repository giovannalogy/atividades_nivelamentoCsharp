using System;

namespace vetorAleatorio
{
    internal class Program
    {
        static void Main()
        {
            const int tamanhoDoVetor = 100;
            int[] vetor = new int[tamanhoDoVetor];

            Random aleatorio = new Random();

            for (int i = 0; i < tamanhoDoVetor; i++)
            {
                vetor[i] = aleatorio.Next(1, 1001);
            }

            int menorNumero = vetor[0];
            int maiorNumero = vetor[0];
            int posicaoMenor = 0;
            int posicaoMaior = 0;

            for (int i = 1; i < tamanhoDoVetor; i++)
            {
                if (vetor[i] > maiorNumero)
                {
                    maiorNumero = vetor[i];
                    posicaoMaior = 1;
                }

                if (vetor[i] < menorNumero)
                {
                    menorNumero = vetor[i];
                    posicaoMenor = 1;
                }
            }

            Console.WriteLine("Maior número: " + maiorNumero + " (posição " + posicaoMaior + ")");
            Console.WriteLine("Menor número: " + menorNumero + " (posição " + posicaoMenor + ")");

        }
    }
}
