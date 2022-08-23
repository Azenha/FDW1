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
            p1.Nome = "Ju";
            p1.Telefone = "912345678";
            p1.Endereco = "Rua do Abacaxi, 88";

            //chamando o método imprimir
            //p1.imprimir();

            Conta c1 = new Conta();
            c1.numero = 11111;
            c1.agencia = 12345;
            c1.titular = p1;
            c1.Depositar(15000);

            c1.imprimir();

            //c1.Depositar(500);
            //c1.Sacar(10000);
            //c1.imprimir();

            Pessoa p2 = new Pessoa();
            p2.Nome = "Leo";
            p2.Telefone = "987654321";
            p2.Endereco = "Av. da Azenha, 86";

            Conta c2 = new Conta();
            c2.numero = 22222;
            c2.agencia = 12345;
            c2.titular = p2;
            c2.Depositar(500);

            c2.imprimir();

            c1.Transferir(500, c2);
            c1.imprimir();
            c2.imprimir();

        }
    }
}
