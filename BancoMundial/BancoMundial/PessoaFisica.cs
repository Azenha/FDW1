using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    public class PessoaFisica : Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        private int Idade { get; }
        private string FaixaEtaria { get; }
        public double Renda { get; set; }
        public PessoaFisica(string nome, string sobrenome, string rg, string cpf, DateTime dataNasc, double renda)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Rg = rg;
            this.Cpf = cpf;
            this.DataNasc = dataNasc;
            this.Renda = renda;
        }
    }
}
