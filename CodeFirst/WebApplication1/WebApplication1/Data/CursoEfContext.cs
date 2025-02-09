using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Entities;

namespace WebApplication1.Data
{
    public class CursoEfContext : DbContext
    {
        public CursoEfContext(DbContextOptions<CursoEfContext> options) : base(options) { }

        public DbSet<User> users { get; set; }  
        public DbSet<WorkingExperience> workingExperiences { get; set; }


    }
}
