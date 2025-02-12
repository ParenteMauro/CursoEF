using WebApplication1.Data.Entities;
using CodeFirst.Data; 

namespace CodeFirst.Services
{
    public class DeleteUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public  async Task<bool> Delete(int id)
        {
            User? user = await _unitOfWork.UserRepository.GetById(id);
            if (user != null)
            {
                try
                {
                    _unitOfWork.UserRepository.Delete(user);
                    await _unitOfWork.Save();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;

                }
            }
            else
                return false;
        }
    }
}
