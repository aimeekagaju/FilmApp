using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilisation;

namespace FilmApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = @"Data Source=E6K-VDI20512\TFTIC;Initial Catalog=Film;Integrated Security=True;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        

        public class ActeurConfig : IEntityTypeConfiguration<Personne>
        {
            public void Configure(EntityTypeBuilder<Personne> builder)
            {
                
                
            }
        }

        public class RealisateurConfig : IEntityTypeConfiguration<Personne>
        {
            public void Configure(EntityTypeBuilder<Personne> builder)
            {
                
                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new ActeurConfig());
            modelBuilder.ApplyConfiguration(new RealisateurConfig());

        }
    }
}