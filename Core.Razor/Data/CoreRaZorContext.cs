using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Razor.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Core.Razor.Areas.Identity.Data;

namespace Core.Razor.Data
{
    public class CoreRaZorContext : IdentityDbContext<CoreRazorUser>
    {
        public CoreRaZorContext (DbContextOptions<CoreRaZorContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Core.Razor.Models.Movie> Movie { get; set; }
        public DbSet<Core.Razor.Models.Book> Book { get; set; }
    }

    //public class IdentityContext : IdentityDbContext<CoreRazorUser>
    //{
    //    public IdentityContext(DbContextOptions<IdentityContext> options)
    //        : base(options)
    //    {
    //    }

    //    protected override void OnModelCreating(ModelBuilder builder)
    //    {
    //        base.OnModelCreating(builder);
    //        // Customize the ASP.NET Identity model and override the defaults if needed.
    //        // For example, you can rename the ASP.NET Identity table names and more.
    //        // Add your customizations after calling base.OnModelCreating(builder);
    //    }
    //}
}
