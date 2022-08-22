using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBanco
{
    public class Conta
    {
        public int numero;
        public int agencia;
        public double saldo;
        // declarar uma variável do tipo Pessoa
        public Pessoa titular;

        public void imprimir()
        {
            titular.imprimir();
            Console.WriteLine(
                $"Número: {numero}, " +
                $"Agência: {agencia}, " +
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
    }
}
