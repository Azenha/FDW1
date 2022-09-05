using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensageiro
{
    public class MsgTexto : Mensagem
    {
        public int NumChar { get; set; }

        public MsgTexto(int numChar)
        {
            this.NumChar = numChar;
        }
    }
}
