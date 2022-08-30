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
            PessoaFisica p1 = new PessoaFisica()
            {
                Nome = "Ju", 
                Telefone = "912345678",
                Endereco = "Rua do Abacaxi, 88",
                Idade = 34,
                Rg = "9876543210",
                Cpf = "98765432100"
            };

            // p1.Nome = "Ju";
            // p1.Telefone = "912345678";
            // p1.Endereco = "Rua do Abacaxi, 88";

            //chamando o método imprimir
            //p1.imprimir();

            Conta c1 = new Conta(11111, 12345, p1);
            //c1.Numero = 11111;
            //c1.Agencia = 12345;
            //c1.Titular = p1;
            c1.Depositar(15000);

            c1.imprimir();

            //c1.Depositar(500);
            //c1.Sacar(10000);
            //c1.imprimir();

            PessoaFisica p2 = new PessoaFisica()
            {
                Nome = "Leo",
                Telefone = "987654321",
                Endereco = "Av. da Azenha, 86",
                Idade = 35,
                Cpf = "12345678900",
                Rg = "0123456789"
            };

            Conta c2 = new Conta(22222, 12345, p2);
            //c2.Numero = 22222;
            //c2.Agencia = 12345;
            //c2.Titular = p2;
            c2.Depositar(500);

            c2.imprimir();

            c1.Transferir(500, c2);
            c1.imprimir();
            p1.imprimir();
            c2.imprimir();
            p2.imprimir();

            PessoaJuridica pj = new PessoaJuridica()
            {
                Nome = "Agência PJ LTDA.",
                Telefone = "999999999",
                Endereco = "Av. do Porto, 2022",
                Idade = 50,
                Cnpj = "1234567890987654321",
                RazaoSocial = "Agencia pj"
            };

            Conta c3 = new Conta(33333, 12345, pj);
            c3.Depositar(50000);

            pj.imprimir();
            c3.imprimir();

            Console.WriteLine("Quantidade: "+Conta.Quantidade);
            Console.WriteLine("Soma 5 + 6 = " + Calculadora.somar(5, 6));

        }
    }
}
