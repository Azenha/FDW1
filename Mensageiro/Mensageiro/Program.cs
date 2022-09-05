using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensageiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contato c1 = new Contato("Leo", "987654321");
            Contato c2 = new Contato("Ju", "912345678");
            Contato c3 = new Contato("Zeus", "954321876");
            Contato c4 = new Contato("Lion", "956784321");
            Mensagem m1 = new MsgTexto(c1,"19:41","Mensagem de texto",10);
            Mensagem m2 = new MsgTexto(c2, "19:43", "Mensagem de texto", 20);
            Mensagem m3 = new MsgFoto(c2, "19:45", "Mensagem de texto", 3);
            Mensagem m4 = new MsgAudio(c3, "19:47", "Mensagem de texto", 40);
            Mensagem m5 = new MsgFoto(c3, "19:49", "Mensagem de texto", 5);
            Mensagem m6 = new MsgAudio(c4, "19:50", "Mensagem de texto", 60);
            Mensageiro instantaneo = new Mensageiro();
            instantaneo.addContato(c1);
            instantaneo.addContato(c2);
            instantaneo.addContato(c3);
            instantaneo.addContato(c4);
            instantaneo.listarContatos();
            instantaneo.addMensagem(m1);
            instantaneo.addMensagem(m2);
            instantaneo.addMensagem(m3);
            instantaneo.addMensagem(m4);
            instantaneo.addMensagem(m5);
            instantaneo.addMensagem(m6);
            instantaneo.listarMensagens();

            Console.WriteLine("\n\n"+m1.ToString());
        }
    }
}
