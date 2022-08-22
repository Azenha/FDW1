using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu salário?");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Precisa comprar para feira");
            string feira = Console.ReadLine();
            string[] produtos = feira.Split(' ');
            string p0 = produtos[0];
            string p1 = produtos[1];
            string p2 = produtos[2];
            Console.WriteLine($"Olá {nome} de {idade} anos! O seu saláio é R$ {salario}.");

            if (idade < -1)
            {
                Console.WriteLine("Você ainda não nasceu.");
            }
            else if ((idade >= 0) && (idade < 18))
            {
                Console.WriteLine("Você é menor de idade.");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }

            Console.WriteLine($"Produtos da feira: {produtos[0]}, {produtos[1]}, {produtos[2]}.");

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.Write(produtos[i] + ", ");
            }

            Console.WriteLine();

            foreach (string i in produtos)
            {
                Console.WriteLine(i);
            }
        }
    }
}
