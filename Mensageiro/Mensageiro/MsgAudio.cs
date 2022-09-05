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

        public MsgAudio(Contato destinatario, string horaEnvio, string conteudo, int duracao)
        {
            this.Destinatario = destinatario;
            this.HoraEnvio = horaEnvio;
            this.Conteudo = conteudo;
            this.Duracao = duracao;
        }
        public override string ToString()
        {
            return "Nova mensagem não lida \nDestinatário: " + Destinatario.Nome.ToString() + "\nEnvio: " + HoraEnvio.ToString() + "\nConteúdo: " + Conteudo.ToString() + "\nDuração em segundos: " + Duracao.ToString();
        }
    }
}
