namespace Elenco.Models
{
    public class Autenticidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public virtual ICollection<Elenco> AutenticidadeAlfa { get; set; }
        public virtual ICollection<Elenco> AutenticidadeBeta { get; set; }
        public virtual ICollection<Elenco> AutenticidadeGama { get; set; }

        public Autenticidade() { }

        public Autenticidade(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

    }
}
