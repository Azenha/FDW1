using System.ComponentModel.DataAnnotations;
namespace Protagonistas.Models
{
    public class Biografia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }
        public Biografia() { }

        public Biografia(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }
    }
}
