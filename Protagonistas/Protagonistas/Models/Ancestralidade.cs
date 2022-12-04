using System.ComponentModel.DataAnnotations;
namespace Protagonistas.Models
{
    public class Ancestralidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }
        public Ancestralidade() { }

        public Ancestralidade(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }
    }
}
