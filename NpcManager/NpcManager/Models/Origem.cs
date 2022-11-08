namespace NpcManager.Models
{
    public class Origem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<Npc> Npcs = new List<Npc>();

        public Origem() {}

        public Origem(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

    }
}
