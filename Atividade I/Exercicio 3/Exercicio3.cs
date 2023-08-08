internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade atual em estoque: ");
        int quantidadeAtual = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a quantidade máxima em estoque: ");
        int quantidadeMaxima = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a quantidade minima em estoque: ");
        int quantidadeMinima = int.Parse(Console.ReadLine());

        double quantidadeMedia = (quantidadeMinima + quantidadeMinima) / 2.0;

        if (quantidadeAtual >= quantidadeMedia)
        {
            Console.WriteLine("Não efetuar compra");

        }
        else
        {
            Console.WriteLine("Efetuar compra");
        }

    }
}