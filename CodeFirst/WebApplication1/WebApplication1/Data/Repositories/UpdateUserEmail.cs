using WebApplication1.Data.Entities;
namespace CodeFirst.Data.Repositories
{
    public class UpdateUserEmail
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateUserEmail(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<bool> Execute(int userId, string email)
        {
            User? user = await _unitOfWork.UserRepository.GetById(userId);
            if (user != null)
            {
                user.Email = email;

                _unitOfWork.UserRepository.Update(user);

                await _unitOfWork.Save();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
