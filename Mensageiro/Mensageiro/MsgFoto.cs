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

        public MsgFoto(Contato destinatario, string horaEnvio, string conteudo, int tamanho)
        {
            this.Destinatario = destinatario;
            this.HoraEnvio = horaEnvio;
            this.Conteudo = conteudo;
            this.Tamanho = tamanho;
        }
        public override string ToString()
        {
            return "Nova mensagem não lida \nDestinatário: " + Destinatario.Nome.ToString() + "\nEnvio: " + HoraEnvio.ToString() + "\nConteúdo: " + Conteudo.ToString() + "\nTamanho da foto em MB: " + Tamanho.ToString();
        }

    }
}
