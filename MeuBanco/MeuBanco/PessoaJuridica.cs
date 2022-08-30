using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBanco
{
    internal class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string cnpj, string razaoSocial)
        {
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
        }

        public void imprimir()
        {
            base.imprimir();
            Console.WriteLine($"CNPJ: {Cnpj}, Razão Social: {RazaoSocial}.");
        }
    }
}
