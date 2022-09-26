using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    public class PessoaJuridica : Pessoa
    {
        public List<PessoaFisica> socios = new List<PessoaFisica>();
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string InscrEstadual { get; set; }
        public DateTime DataAbertura { get; set; }
        private int Idade { get; }
        public double Faturamento { get; set; }

        public PessoaJuridica(List<PessoaFisica> socios, string cnpj, string razaoSocial, string nomeFantasia, string inscrEstadual, DateTime dataAbertura, double faturamento)
        {
            this.socios = socios;
            this.Cnpj = cnpj;
            this.RazaoSocial = razaoSocial;
            this.NomeFantasia = nomeFantasia;
            this.InscrEstadual = inscrEstadual;
            this.DataAbertura = dataAbertura;
            this.Faturamento = faturamento;
        }
    }
}
