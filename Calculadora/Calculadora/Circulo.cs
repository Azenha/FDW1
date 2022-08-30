using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }
        public override double Area => Math.Pow(this.Raio, 2) * Math.PI;
    }
}
