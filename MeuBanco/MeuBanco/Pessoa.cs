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
        public string nome;
        public string telefone;
        public string endereco;

        // Declarando um método sem retorno
        public void imprimir()
        {
            Console.WriteLine(
                $"Nome: {nome}, " +
                $"Telefone: {telefone}, " +
                $"Endereço: {endereco}.");
        }
    }
}
