using System;
namespace Imposto
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe as horas trabalhadas por semana: ");
            double valorBase = double.Parse(Console.ReadLine());

            double imposto = 0.00;

            if (valorBase <= 1200.00)
            {
                Console.WriteLine("Isento");
                imposto = 0.0;
            }
            else if (valorBase <= 2500.00)
            {
                Console.WriteLine("10% de imposto");
                imposto = valorBase * 0.1;
            }
            else if (valorBase <= 5000.00)
            {
                Console.WriteLine("15% de imposto");
                imposto = valorBase * 0.15;
            }
            else
            {
                Console.WriteLine("20% de imposto");

            }

            Console.WriteLine("O imposto calculado a pagar é: " + imposto);
        }
    }
}