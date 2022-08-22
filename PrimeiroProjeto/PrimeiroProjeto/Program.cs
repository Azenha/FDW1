using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentário em uma linha
            /*Declarando variáveis*/
            bool completo = false; //true
            char genero = 'F';
            char simbolo = '\u0041';
            byte n1 = 126;
            int idade = 20;
            long cod = 96745;
            float peso = 65.5f;
            double salario = 30000.50;
            decimal investimentos = 8184894561;
            string nome = "Joana";

            Console.WriteLine("Informações da " + nome);
            Console.WriteLine("Completo? " + completo);
            Console.WriteLine("Gênero " + genero);
            Console.WriteLine("Símbolo: " + simbolo);
            Console.WriteLine("idade: " + idade);
            Console.WriteLine("Código: " + cod);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Salário" + salario);
            Console.WriteLine("Investimento" + investimentos);
            Console.WriteLine("n1" + n1);

            /*conversão 1*/
            double comissao;
            int gorjeta, total;
            comissao = 15306.589841;
            gorjeta = 5;
            total = (int)comissao + gorjeta;
            Console.WriteLine("Comissão: R$ " + comissao.ToString("F2"));
            string teste = comissao.ToString();

            /*Conversão 2*/
            int num1 = 5;
            int num2 = 2;
            double resultado = (double)num1 / num2;
            Console.WriteLine("divisao: " + resultado);

        }
    }
}