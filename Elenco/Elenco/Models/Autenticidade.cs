namespace Elenco.Models
{
    public class Autenticidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public virtual ICollection<Coadjuvante> AutenticidadeAlfa { get; set; }
        public virtual ICollection<Coadjuvante> AutenticidadeBeta { get; set; }
        public virtual ICollection<Coadjuvante> AutenticidadeGama { get; set; }

        public Autenticidade() { }

        public Autenticidade(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

    }
}
