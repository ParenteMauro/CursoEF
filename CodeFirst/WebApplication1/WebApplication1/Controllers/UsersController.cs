using CodeFirst.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Entities;
using CodeFirst.Services;

namespace CodeFirst.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly UpdateUserEmail _updateEmailUser;
        private readonly DeleteUserService _deleteUser;
        public UsersController(IUserRepository userRepository, UpdateUserEmail updateUserEmail, DeleteUserService deleteUser)
        {
            _userRepository = userRepository;
            _updateEmailUser = updateUserEmail;
            _deleteUser = deleteUser;       
        }
        [HttpGet]
        public async Task<List<User>> GetAll() => await _userRepository.GetAll();

        [HttpPatch(template:"update-email/{userId}")]
        public async Task<bool> UpdateEmail(int userId, string email)
            => await _updateEmailUser.Execute(userId, email);


        [HttpDelete(template: "delete-user/{userId}")]
        public async Task<bool> DeleteUser(int userId)
        => await _deleteUser.Delete(userId);
    }
}
