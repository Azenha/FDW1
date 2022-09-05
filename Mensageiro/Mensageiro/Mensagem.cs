using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensageiro
{
    public abstract class Mensagem
    {
        public Contato Destinatario { get; set; }
        public string HoraEnvio { get; set; }
        public string Conteudo{ get; set; }

        public Mensagem() { }
        public Mensagem(Contato destinatario, string horaEnvio, string conteudo)
        {
            this.Destinatario = destinatario;
            this.HoraEnvio = horaEnvio;
            this.Conteudo = conteudo;
        }
        public override string ToString()
        {
            return base.ToString() + "Destinatário: " + Destinatario.ToString() + "Envio: " + HoraEnvio.ToString() + "Conteúdo: " + Conteudo.ToString();
        }
    }

}
