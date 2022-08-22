using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Instanciando um objeto */
            Pessoa p1 = new Pessoa();
            p1.nome = "Ju";
            p1.telefone = "912345678";
            p1.endereco = "Rua do Abacaxi, 88";

            //chamando o método imprimir
            //p1.imprimir();

            Conta c1 = new Conta();
            c1.numero = 11111;
            c1.agencia = 12345;
            c1.saldo = 20000.00;
            c1.titular = p1;

            c1.imprimir();

            c1.Depositar(500);
            c1.Sacar(10000);
            c1.imprimir();

        }
    }
}
