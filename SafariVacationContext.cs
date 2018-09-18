using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ormsafari.Models;

namespace ormsafari
{
    public partial class SafariVacationContext : DbContext
    {
        public SafariVacationContext()
        {
        }

        public SafariVacationContext(DbContextOptions<SafariVacationContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("server=localhost;database=SafariVacation;Username=postgres;Password=warrior;Integrated Security=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}


        public DbSet<SeenAnimals> SeenAnimalsTable { get; set; }
    }
}
