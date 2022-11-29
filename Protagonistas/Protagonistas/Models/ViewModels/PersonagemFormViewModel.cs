namespace Protagonistas.Models.ViewModels
{
    public class PersonagemFormViewModel
    {
        public Personagem? Personagem { get; set; }
        public ICollection<Ancestralidade>? Ancestralidades { get;set; }
        public ICollection<Biografia>? Biografias { get; set; }
        public ICollection<Caminho>? Caminhos { get; set; }
    }
}
