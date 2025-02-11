using CodeFirst.Data.Seeds;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Entities;

namespace WebApplication1.Data
{
    public class CursoEfContext : DbContext
    {
        public CursoEfContext(DbContextOptions<CursoEfContext> options) : base(options) { }

        public DbSet<User> users { get; set; }  
        public DbSet<WorkingExperience> workingExperiences { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfigurationsFromAssembly(); busca todas las clases que usen la interfaz de IEntityTypeConfiguration automaticamente con reflection
            builder.ApplyConfiguration(new UserSeed());
        }
    }
}
