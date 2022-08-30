using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBanco
{
    internal class PessoaFisica : Pessoa
    {
        public string Rg { get; set; }
        public string Cpf { get; set; }

        public void imprimir()
        {
            base.imprimir();
            Console.WriteLine($"RG: {Rg}, CPF: {Cpf}.");
        }
    }
}
