using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Triangulo : Forma
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }
        public double CalcularArea()
        {
            double p = (LadoA + LadoB + LadoC) / 2.0;
            return Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));
        }
        public override double Area => CalcularArea();

    }
}
