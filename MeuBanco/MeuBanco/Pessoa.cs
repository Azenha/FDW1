using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBanco
{
    /* declarando uma classe pública e abstrata */
    public abstract class Pessoa
    {
        // atributos
        private string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        /*implementação manual de get set
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

        }*/
        public int Idade { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, string telefone, string endereco)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Endereco = endereco;
            Idade = 0;
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
                $"Endereço: {Endereco}, " +
                $"Idade: {Idade}.");
        }
    }
}
