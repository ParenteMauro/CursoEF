using CodeFirst.Data.Repositories;
using CodeFirst.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Data.Entities;

namespace CodeFirst.Controllers
{
    [ApiController]

    public class TestController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly InsertUserWithExperiencesService _insertUserWithExperiences;
        public TestController(IUserRepository userRepository, InsertUserWithExperiencesService insertUserWithExperiencesService)
        {
            _userRepository = userRepository;
            _insertUserWithExperiences = insertUserWithExperiencesService;
        }
        [HttpPost(template:"user")]
        public async Task Create () => await _insertUserWithExperiences.Execute();

        [HttpPost(template: "test")]
        public async Task Test()
        {
            User user1 = new User()
            {
                Email = "X23123@gmail.com",
                UserName = "Test",
                Password = "testPss",

                WorkingExperiences = new List<WorkingExperience>()
                {
                    new WorkingExperience()
                    {
                        Name = "experience4",
                        Details = "Details4",
                        Environment = "environtment"
                    },
                    new WorkingExperience()
                    {
                        Name = "experience9",
                        Details = "Details9",
                        Environment = "environtment"
                    }
                }
            };
           await _userRepository.Insert(user1);
          
        }

        [HttpGet("{userId}")]
        public async Task<User?> Get(int userId)
        => await _userRepository.GetById(userId);

        [HttpGet(template:"user-page/{pageNumber}")]
        public async Task<List<User>> GetPage(int pageNumber, int pageSize)
        {
            IQueryable<User> pageInfo = _userRepository.GetPagination(pageNumber, pageSize);

            var result = await pageInfo.ToListAsync(); //Ejecución de consulta
            return result; 
        }
    }
}
