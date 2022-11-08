namespace NpcManager.Models
{
    public class Autenticidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Autenticidade() {}

        public Autenticidade(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

    }
}
