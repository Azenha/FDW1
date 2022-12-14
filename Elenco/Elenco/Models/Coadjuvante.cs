using System.ComponentModel.DataAnnotations.Schema;

namespace Elenco.Models
{
    public class Coadjuvante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Retrato { get; set; }
        public Origem? Origem { get; set; }
        [InverseProperty("ExperienciaAlfa")]
        public virtual Experiencia? ExperienciaAlfa { get; set; }
        [InverseProperty("ExperienciaBeta")]
        public virtual Experiencia? ExperienciaBeta { get; set; }
        [InverseProperty("AutenticidadeAlfa")]
        public virtual Autenticidade? AutenticidadeAlfa { get; set; }
        [InverseProperty("AutenticidadeBeta")]
        public virtual Autenticidade? AutenticidadeBeta { get; set; }
        [InverseProperty("AutenticidadeGama")]
        public virtual Autenticidade? AutenticidadeGama { get; set; }

        public Coadjuvante() { }

        public Coadjuvante(int id, string nome, string? descricao, string? retrato, Origem? origem, Experiencia? experienciaAlfa, Experiencia? experienciaBeta, Autenticidade? autenticidadeAlfa, Autenticidade? autenticidadeBeta, Autenticidade? autenticidadeGama)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Retrato = retrato;
            Origem = origem;
            ExperienciaAlfa = experienciaAlfa;
            ExperienciaBeta = experienciaBeta;
            AutenticidadeAlfa = autenticidadeAlfa;
            AutenticidadeBeta = autenticidadeBeta;
            AutenticidadeGama = autenticidadeGama;
        }

    }
}
