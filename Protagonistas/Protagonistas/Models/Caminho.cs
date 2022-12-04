using System.ComponentModel.DataAnnotations;
namespace Protagonistas.Models
{
    public class Caminho
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }
        public Caminho() { }

        public Caminho(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }
    }
}
