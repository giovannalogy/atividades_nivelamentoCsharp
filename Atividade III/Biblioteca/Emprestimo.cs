using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    
    internal class Emprestimo
    {
        //atributos 
        public Pessoa Pessoa { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataEstimadaEstorno { get; set; }

                
        //Construtor 
        public Emprestimo(Pessoa pessoa, Livro livro, DateTime dataEmprestimo, DateTime dataEstimadaEstorno)
        {
            Pessoa = pessoa;
            Livro = livro;
            DataEmprestimo = DateTime.Now; 
            DataEstimadaEstorno = dataEstimadaEstorno;
            livro.QuantidadeDeExemplares--;
        }

        public static Emprestimo RealizarEmprestimo(Pessoa pessoa, Livro livro, DateTime dataEmprestimo, DateTime dataEstimadaEstorno)
        {
            if (!pessoa.RealizouEmprestimo && livro.QuantidadeDeExemplares > 0)
            {
                pessoa.RealizouEmprestimo = true;
                return new Emprestimo(pessoa, livro, dataEmprestimo, dataEstimadaEstorno);
            }
            else if (pessoa.RealizouEmprestimo)
            {
                Console.WriteLine($"{pessoa.Nome} já realizou um empréstimo.");
            }
            else if (livro.QuantidadeDeExemplares <= 0)
            {
                Console.WriteLine($"Não há exemplares disponíveis do livro {livro.Titulo}.");
            }

            return null;
        }
    }
}
