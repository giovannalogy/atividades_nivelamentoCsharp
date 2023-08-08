using System;


namespace AtividadeII
{
    public class Produto
    {
        //Atributos privados da classe Produto
        private string Nome { get; set; }
        private double Preco { get; set; }
        private int Quantidade { get; set; }

        //Construtor da classe 
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }
             

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade; 
        }

        public void RemoverProdutos(int quantidade)
        {
            if (quantidade <= Quantidade)
            {
                Quantidade -= quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade do estoque está induficiente.");
            }
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}\nPreço: {Preco:C}\nQuantidade em Estoque: {Quantidade}\nValor Total em Estoque: {ValorTotalEmEstoque():C}");
        }
    }
}
