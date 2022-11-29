using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Protagonistas.Models;

namespace Protagonistas.Data
{
    public class ProtagonistasContext : DbContext
    {
        public ProtagonistasContext (DbContextOptions<ProtagonistasContext> options)
            : base(options)
        {
        }

        public DbSet<Protagonistas.Models.Ancestralidade> Ancestralidade { get; set; } = default!;

        public DbSet<Protagonistas.Models.Biografia> Biografia { get; set; }

        public DbSet<Protagonistas.Models.Caminho> Caminho { get; set; }

        public DbSet<Protagonistas.Models.Personagem> Personagem { get; set; }
    }
}
