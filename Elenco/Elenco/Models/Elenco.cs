namespace Elenco.Models
{
    public class Elenco
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Retrato { get; set; }
        public int? Origem { get; set; }
        public int? ExperienciaAlfaId { get; set; }
        public int? ExperienciaBetaId { get; set; }
        public int? AutenticidadeAlfaId { get; set; }
        public int? AutenticidadeBetaId { get; set; }
        public int? AutenticidadeGamaId { get; set; }
        public virtual Experiencia ExperienciaAlfa { get; set; }
        public virtual Experiencia ExperienciaBeta { get; set; }
        public virtual Autenticidade AutenticidadeAlfa { get; set; }
        public virtual Autenticidade AutenticidadeBeta { get; set; }
        public virtual Autenticidade AutenticidadeGama { get; set; }

        //public Origem? Origem { get; set; }
        //public Experiencia? Experiencia { get; set; }
        //public Autenticidade? Autenticidade { get; set; }
        public Elenco() { }

        //public Elenco(int id, string nome, string? descricao, string? retrato, Origem? origem, Experiencia? experiencia, Autenticidade? autenticidade)
        //{
        //    Id = id;
        //    Nome = nome;
        //    Descricao = descricao;
        //    Retrato = retrato;
        //    Origem = origem;
        //    Experiencia = experiencia;
        //    Autenticidade = autenticidade;
        //}
    }
}
