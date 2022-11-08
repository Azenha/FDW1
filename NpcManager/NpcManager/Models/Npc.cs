namespace NpcManager.Models
{
    public class Npc
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Retrato { get; set; }
        public Origem Origem { get; set; }
        public Experiencia ExperienciaUm { get; set; }
        public Experiencia ExperienciaDois { get; set; }
        public Autenticidade AutenticidadeUm { get; set; }
        public Autenticidade AutenticidadeDois { get; set; }
        public Autenticidade AutenticidadeTres { get; set; }

        public Npc() { }
        public Npc(int id, string nome, string descricao, string retrato, Origem origem, Experiencia experienciaUm, Experiencia experienciaDois, Autenticidade autenticidadeUm, Autenticidade autenticidadeDois, Autenticidade autenticidadeTres)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Retrato = retrato;
            Origem = origem;
            ExperienciaUm = experienciaUm;
            ExperienciaDois = experienciaDois;
            AutenticidadeUm = autenticidadeUm;
            AutenticidadeDois = autenticidadeDois;
            AutenticidadeTres = autenticidadeTres;
        }
    }
}
