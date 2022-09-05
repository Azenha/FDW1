using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensageiro
{
    public class MsgFoto : Mensagem
    {
        public int Tamanho { get; set; }

        public MsgFoto (int tamanho)
        {
            this.Tamanho = tamanho;
        }
    }
}
