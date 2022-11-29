using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Protagonistas.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }
        public string? Retrato { get; set; }
        [Display(Name = "Ancestralidade")]
        public int? AncestralidadeId { get; set; }
        public Ancestralidade? Ancestralidade { get; set; }
        [Display(Name = "Biografia")]
        public int? BiografiaId { get; set; }
        public Biografia? Biografia { get; set; }
        [Display(Name = "Caminho")]
        public int? CaminhoId { get; set; }
        public Caminho? Caminho { get; set; }
        public Personagem() 
        {
        }

        public Personagem(int id, string nome, string? descricao, string? retrato)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Retrato = retrato;
        }
    }
}
