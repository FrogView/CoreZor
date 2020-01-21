using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Razor.Models;

namespace Core.Razor.Data
{
    public class CoreRaZorContext : DbContext
    {
        public CoreRaZorContext (DbContextOptions<CoreRaZorContext> options)
            : base(options)
        {
        }

        public DbSet<Core.Razor.Models.Movie> Movie { get; set; }
        public DbSet<Core.Razor.Models.Book> Book { get; set; }
    }
}
