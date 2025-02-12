using CodeFirst.Data.Repositories;
using WebApplication1.Data;

namespace CodeFirst.Data
{
    public interface IUnitOfWork : IDisposable
    {
        public IUserRepository UserRepository { get; }
        public IWorkingExperienceRepository WorkingExperienceRepository { get; }
        Task<int> Save();

    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CursoEfContext _context;
        public IUserRepository UserRepository { get; }
        public IWorkingExperienceRepository WorkingExperienceRepository { get; }
        public UnitOfWork(CursoEfContext context, IUserRepository userRepository, IWorkingExperienceRepository workingExperience)
        {
             _context = context;
             UserRepository = userRepository;
             WorkingExperienceRepository = workingExperience;
        }

        public void Dispose()
        {
            _context.Dispose(); //Evitamos conexiones abiertas para liberar memoria
        }

        public async Task<int> Save()
        => await _context.SaveChangesAsync();
        
    }
}
