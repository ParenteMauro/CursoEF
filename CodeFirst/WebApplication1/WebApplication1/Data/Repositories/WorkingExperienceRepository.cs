using WebApplication1.Data;
using WebApplication1.Data.Entities;

namespace CodeFirst.Data.Repositories
{
    public interface IWorkingExperienceRepository
    {
        Task Insert(List<WorkingExperience> workingExperiences);
    }
    public class WorkingExperienceRepository : IWorkingExperienceRepository
    {
        private CursoEfContext _context;
        public WorkingExperienceRepository(CursoEfContext context)
        {
            _context = context;
        }
        public async Task Insert(List<WorkingExperience> workingExperiences)
            => await _context.workingExperiences.AddRangeAsync(workingExperiences);
        
    }
}
