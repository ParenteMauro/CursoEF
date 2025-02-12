using CodeFirst.Data;
using CodeFirst.Data.Repositories;
using WebApplication1.Data.Entities;

namespace CodeFirst.Services
{
    public class InsertUserWithExperiencesService
    {

        private readonly IUnitOfWork _unitOfWork;
        public InsertUserWithExperiencesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Execute()
        {
            User user = new User()
            {
                
                Email = $"userasdasd@gmail.com",
                UserName = $"userasdasd",
                Password = $"userasdasdd",
            };
            List<WorkingExperience> workingExperiences = new List<WorkingExperience>()
                {
                    new WorkingExperience()
                    {
                        User = user,
                        UserId = user.Id,
                        Name = $"experience user{user.Id}",
                        Details = "Details4",
                        Environment = "environtment"
                    },
                    new WorkingExperience()
                    {
                        User = user,
                        UserId= user.Id,
                        Name = $"experience user{user.Id}",
                        Details = "Details9",
                        Environment = "environtment 2"
                    }
                };
            await _unitOfWork.UserRepository.Insert(user);
            await _unitOfWork.WorkingExperienceRepository.Insert(workingExperiences);
            await _unitOfWork.Save();
        }
    }
}

