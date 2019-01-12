using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBanco
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }

        public Cliente(string nome, string cpf, DateTime dataNascimento, Endereco endereco)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Endereco = endereco;
        }

        public bool VerificarMaioridade()
        {
            var nascimentoMinimo = DateTime.Now.AddYears(-18);
            var verificaMaioridade = DataNascimento <= nascimentoMinimo;

            return verificaMaioridade;
        }
    }
}
