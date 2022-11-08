using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NpcManager.Models;

namespace NpcManager.Data
{
    public class NpcManagerContext : DbContext
    {
        public NpcManagerContext (DbContextOptions<NpcManagerContext> options)
            : base(options)
        {
        }

        public DbSet<NpcManager.Models.Origem> Origem { get; set; } = default!;

        public DbSet<NpcManager.Models.Autenticidade> Autenticidade { get; set; }

        public DbSet<NpcManager.Models.Experiencia> Experiencia { get; set; }

        public DbSet<NpcManager.Models.Npc> Npc { get; set; }
    }
}
