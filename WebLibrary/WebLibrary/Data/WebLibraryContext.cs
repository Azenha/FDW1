using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebLibrary.Models;

namespace WebLibrary.Data
{
    public class WebLibraryContext : DbContext
    {
        public WebLibraryContext (DbContextOptions<WebLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<WebLibrary.Models.Product> Product { get; set; } = default!;
    }
}
