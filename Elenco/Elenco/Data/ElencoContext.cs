using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Elenco.Models;

namespace Elenco.Data
{
    public class ElencoContext : DbContext
    {
        public ElencoContext (DbContextOptions<ElencoContext> options)
            : base(options)
        {
        }

        public DbSet<Elenco.Models.Autenticidade> Autenticidade { get; set; } = default!;

        public DbSet<Elenco.Models.Coadjuvante> Elenco { get; set; }

        public DbSet<Elenco.Models.Origem> Origem { get; set; }

        public DbSet<Elenco.Models.Experiencia> Experiencia { get; set; }
    }
}
