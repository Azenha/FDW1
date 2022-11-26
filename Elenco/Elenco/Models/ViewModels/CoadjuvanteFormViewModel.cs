using NuGet.Protocol.Plugins;

namespace Elenco.Models.ViewModels
{
    public class CoadjuvanteFormViewModel
    {
        public Coadjuvante? Coadjuvante { get; set; }
        public ICollection<Origem>? Origems { get; set; }
        public ICollection<Experiencia>? ExperienciaAlfa { get; set; }
        public ICollection<Experiencia>? ExperienciaBeta { get; set; }
        public ICollection<Autenticidade>? AutenticidadeAlfa { get; set; }
        public ICollection<Autenticidade>? AutenticidadeBeta { get; set; }
        public ICollection<Autenticidade>? AutenticidadeGama { get; set; }
    }
}
