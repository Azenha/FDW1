using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensageiro
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Celular { get; set; }
        public Contato() { }
        public Contato(string nome, string celular)
        {
            this.Nome = nome;
            this.Celular = celular;
        }
    }

}
