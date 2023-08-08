using System;

 class Program
 {
    static void Main()
    {
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;

        int tipoCombustível;

        do
        {
            Console.WriteLine("Informe o tipo de combustível abastecido:");
            Console.WriteLine("1. Álcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. Fim");

            tipoCombustivel = int.Parse(Console.ReadLine());

            if (tipoCombustivel >= 1 && tipoCombustivel <= 3)
            {
                switch (tipoCombustivel)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                }
            }

            else if (tipoCombustivel != 4)
            {
                Console.WriteLine("Código inválido. Por favor, informe um código válido.");
            }

        } while (tipoCombustivel != 4);

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Álcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);


    }


 }
 
 