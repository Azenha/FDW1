using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBanco
{
    /* declarando uma classe pública */
    public class Pessoa
    {
        // atributos
        private string nome;
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        //implementação manual de get set
        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }

        }

        /* Controle de acesso à variável
        public string Nome()
        {
            return nome;
        }

        public void Nome(string nome)
        {
            this.nome = nome;
        }

        */

        // Declarando um método sem retorno
        public void imprimir()
        {
            Console.WriteLine(
                $"Nome: {Nome}, " +
                $"Telefone: {Telefone}, " +
                $"Endereço: {Endereco}.");
        }
    }
}
