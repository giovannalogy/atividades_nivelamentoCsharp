using System;

namespace AtividadeII
{
    public class Estoque
    {
        static void Main()
        {
            Console.WriteLine("Insira o nome do produto");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira o preço do produto:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade do produto:");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            Console.WriteLine("\nDados do Produto:");
            produto.MostrarDados();

            Console.WriteLine("\nRealizar entrada de estoque:");
            int entrada = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(entrada);

            Console.WriteLine("\nDados do produto após entrada:");
            produto.MostrarDados();

            Console.WriteLine("\nRealizar saída de estoque:");
            int saida = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(saida);

            Console.WriteLine("\nDados do produto após saída:");
            produto.MostrarDados();

        }
    }
}