using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Data.Entities;

namespace CodeFirst.Controllers
{
    public class TestController : Controller
    {
        public readonly CursoEfContext _CursoEfContext;
        public TestController(CursoEfContext CursoEfContext)
        {
            _CursoEfContext = CursoEfContext;
        }

        [HttpPost(template: "test")]
        public async Task Test()
        {
            User user1 = new User()
            {
                Email = "userX@gmail.com",
                UserName = "Test",
                Password = "testPss",
                
                WorkingExperiences = new List<WorkingExperience>()
                {
                    new WorkingExperience()
                    {
                        Name = "experience1",
                        Details = "Details1",
                        Environment = "environtment"
                    },
                    new WorkingExperience()
                    {
                        Name = "experience2",
                        Details = "Details2",
                        Environment = "environtment"
                    }
                }
            };
            await _CursoEfContext.users.AddAsync(user1);
            await _CursoEfContext.SaveChangesAsync();
        }
        [HttpGet("{userId}")]
        public async Task<User?> Get(int userId)
        {
            var response = await _CursoEfContext.users
                .Include(a=>a.WorkingExperiences)
                .FirstOrDefaultAsync(u => u.Id == userId);
            return response;
        }
    }
}
