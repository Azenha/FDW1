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

        public MsgTexto(Contato destinatario, string horaEnvio, string conteudo, int numChar)
        {
            this.Destinatario = destinatario;
            this.HoraEnvio = horaEnvio;
            this.Conteudo = conteudo;
            this.NumChar = numChar;
        }
        public override string ToString()
        {
            return "Nova mensagem não lida \nDestinatário: " + Destinatario.Nome.ToString() + "\nEnvio: " + HoraEnvio.ToString() + "\nConteúdo: " + Conteudo.ToString() + "\nNúmero de caracteres: " + NumChar.ToString();
        }
    }
}
