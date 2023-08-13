using Biblioteca;
using System;



class Program
{
    static void Main(string[] args)
    {
        //Pessoas e livros cadastrados conforme atributos da classe Pessoa e Livro 
        Pessoa pessoa1 = new Pessoa("Diego", 25, 25123458971, false);
        Pessoa pessoa2 = new Pessoa("Luana", 30, 12345678909, false);

        Livro livro1 = new Livro("Morro dos ventos uivantes", "Emily Bronte", 1, 20);
        Livro livro2 = new Livro("O Senhor dos Anéis", "Tokien", 2, 20);

        DateTime dataEmprestimo1 = DateTime.Now;
        DateTime dataEstimadaEstorno1 = dataEmprestimo1.AddDays(14);

        Emprestimo emprestimo1 = Emprestimo.RealizarEmprestimo(pessoa1, livro1, DateTime.Now, DateTime.Now.AddDays(14));
        if (emprestimo1 != null)
        {
            Console.WriteLine($"{pessoa1.Nome} realizou um empréstimo de {livro1.Titulo} em {emprestimo1.DataEmprestimo}");
            Console.WriteLine($"Devolução do exemplar até: {emprestimo1.DataEstimadaEstorno}");
            Console.WriteLine($"Exemplare(s) restante(s) do livro {livro1.Titulo}: {livro1.QuantidadeDeExemplares}");
        }

        Emprestimo emprestimo2 = Emprestimo.RealizarEmprestimo(pessoa2, livro2, DateTime.Now, DateTime.Now.AddDays(14));
        if (emprestimo2 != null)
        {
            Console.WriteLine($"{pessoa2.Nome} realizou um empréstimo de {livro2.Titulo} em {emprestimo2.DataEmprestimo}");
            Console.WriteLine($"Devolução do exemplar até: {emprestimo2.DataEstimadaEstorno}");
            Console.WriteLine($"Exemplare(s) restante(s) do livro {livro2.Titulo}: {livro2.QuantidadeDeExemplares}");
        }
    }
}

