using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        public enum Menu
        {
            Sair = 0,
            Quadrado = 1,
            Triangulo = 2,
            Circulo = 3
        }

        static void Main(string[] args)
        {
            Menu escolha = Menu.Quadrado;
            while ((escolha = GetEscolha()) != Menu.Sair)
            {
                Forma forma = null;
                switch (escolha)
                {
                    case Menu.Quadrado:
                        forma = CriaQuadrado();
                        break;
                    case Menu.Triangulo:
                        forma = CriaTriangulo();
                        break;
                    case Menu.Circulo:
                        forma = CriaCirculo();
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"A área do {escolha} é {forma.Area}");
                Console.WriteLine();
            }
            Environment.Exit(0);
        }

        public static Menu GetEscolha()
        {
            Console.WriteLine("Escolha a forma geométrica calcular a Área :");
            Console.WriteLine("\t{0} - Quadrado", (int)Menu.Quadrado);
            Console.WriteLine("\t{0} - Triângulo", (int)Menu.Triangulo);
            Console.WriteLine("\t{0} - Círculo", (int)Menu.Circulo);
            Console.WriteLine("\t{0} - Sair", (int)Menu.Sair);
            Console.Write("Escolha : ");
            string valor = Console.ReadLine();
            Menu escolha;
            if (!Enum.TryParse(valor, out escolha) || !Enum.IsDefined(typeof(Menu), escolha))
            {
                Console.WriteLine("Opção inválida, escolha uma opção válida.");
                return GetEscolha();
            }
            return escolha;
        }
        private static double GetDouble(string prompt)
        {
            bool isValido = false;
            double valor = 0;
            while (!isValido)
            {
                Console.Write(prompt);
                isValido = double.TryParse(Console.ReadLine(), out valor);
            }
            return valor;
        }
        private static Quadrado CriaQuadrado()
        {
            double lado = GetDouble("Aresta: ");
            return new Quadrado() { Lado = lado };
        }

        private static Triangulo CriaTriangulo()
        {
            double valorA = GetDouble("Lado A: ");
            double valorB = GetDouble("Lado B: ");
            double valorC = GetDouble("Lado C: ");
            return new Triangulo()
            {
                LadoA = valorA,
                LadoB = valorB,
                LadoC = valorC
            };
        }

        private static Circulo CriaCirculo()
        {
            double raio = GetDouble("Raio: ");
            return new Circulo()
            {
                Raio = raio
            };
        }
    }
}
