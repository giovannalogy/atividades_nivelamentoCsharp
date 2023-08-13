using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Livro
    {
        //atributos 
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int IdLivro { get; set; }
        public int QuantidadeDeExemplares { get; set; }

        public Livro(string titulo, string autor, int idLivro, int quantidadeDeExemplares)
        {
            Titulo = titulo;
            Autor = autor;
            IdLivro = idLivro;
            QuantidadeDeExemplares = quantidadeDeExemplares;
        }
    }
}

