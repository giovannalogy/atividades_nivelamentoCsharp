using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Biblioteca
{
    internal class Pessoa
    {
        //atributos 
        public string Nome { get; set; }
        public int Idade { get; set; }
        public long CPF { get; set; }
        public bool RealizouEmprestimo { get; set; }

        //Construtor
        public Pessoa(string nome, int idade, long cpf, bool realizouEmprestimo)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
            RealizouEmprestimo = realizouEmprestimo;
        }
    }
}
