using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 35;
            double saldo = 8765.43;
            string nome = "Leonardo";

            Console.WriteLine("{0} tem {1} anos e saldo de R$ {2:F2}", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e saldo de R$ {saldo:F2}");
        }
    }
}
