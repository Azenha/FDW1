namespace NpcManager.Models
{
    public class Experiencia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Experiencia() {}

        public Experiencia(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

    }
}
