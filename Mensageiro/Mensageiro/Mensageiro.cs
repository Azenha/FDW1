using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensageiro
{
    internal class Mensageiro
    {
        private List<Contato> contatos = new List<Contato>();
        private List<Mensagem> mensagens = new List<Mensagem>();
        public void addContato(Contato contato)
        {
            contatos.Add(contato);
        }
        public void addMensagem(Mensagem mensagem)
        {
            mensagens.Add(mensagem);
        }
        public void listarContatos()
        {
            foreach (Contato contato in contatos)
            {
                Console.WriteLine($"Nome: {contato.Nome} \t Número: {contato.Celular}");
            }
        }
        public void listarMensagens()
        {
            foreach (Mensagem mensagem in mensagens)
            {
                Console.WriteLine($"\nMensagem: {mensagem}");
            }
        }
    }
}
