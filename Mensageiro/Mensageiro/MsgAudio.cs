using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensageiro
{
    public class MsgAudio : Mensagem
    {
        public int Duracao { get; set; }

        public MsgAudio(int duracao)
        {
            this.Duracao = duracao;
        }
    }
}
