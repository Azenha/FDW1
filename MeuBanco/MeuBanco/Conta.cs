using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBanco
{
    public class Conta
    {
        public static int Quantidade { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        private double saldo;
        // declarar uma variável do tipo Pessoa
        public Pessoa Titular { get; set; }

        public Conta()
        {
            this.saldo = 0;
            Quantidade++;
        }
        public Conta(int numero, int agencia, Pessoa titular)
        {
            this.Numero = numero;
            this.Agencia = agencia;
            this.saldo = 0;
            this.Titular = titular;
            Quantidade++;
        }

        public void imprimir()
        {
            //Titular.imprimir();
            Console.WriteLine(
                $"Número: {Numero}, " +
                $"Agência: {Agencia}, " +
                $"Saldo: {saldo}.");
        }

        public void Depositar(double valor)
        {
            // saldo = saldo + valor;
            saldo += valor;
            Console.WriteLine($"Foi realizado o depósito de R$ {valor}.");
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                // saldo = saldo - valor;
                saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} efetuado com sucesso.");
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }

        }

        public void Transferir(double valor, Conta destino)
        {
            /* (saldo >= valor)
            {
                saldo -= valor;
                destino.saldo += valor;
            } */
            if (this.Sacar(valor))
            {
                destino.Depositar(valor);
            }

        }
    }
}
