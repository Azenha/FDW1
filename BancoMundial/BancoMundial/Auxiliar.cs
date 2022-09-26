using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    public class Auxiliar
    {
        public int CalculaIdade(DateTime nascimento)
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - nascimento.Year;
            return idade;
        }
    }
}
