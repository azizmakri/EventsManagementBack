using EventManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.API.Data
{
    public class DataContext: IdentityDbContext<Utilisateur>
    {
        public DbSet<Utilisateur> Users { get; set; }
        public DbSet<Evennement> Evennements { get; set; }
        public DbSet<Participation> Participations { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)

        {

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);

            base.OnModelCreating(modelBuilder);

        }
    }
}
