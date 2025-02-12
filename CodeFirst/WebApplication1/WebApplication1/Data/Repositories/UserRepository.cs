/*
        Repository Pattern : Patrón de diseño que aísla la lógica de acceso a datos del resto de la aplicación.
               ✔ Evita que los controladores trabajen directamente con Entity Framework.
               ✔ Encapsula la lógica de consultas y manipulación de datos en una capa intermedia.
               ✔ Permite cambiar la base de datos sin modificar el código del controlador.
 */
using WebApplication1.Data;
using WebApplication1.Data.Entities;

using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data.Repositories
{
    public interface IUserRepository
    {
        Task<User?> Insert(User user);
        Task<User?> GetById(int id);

        Task<List<User>>? GetAll();
        void Update(User user);
        void Delete(User user);
    }
    public class UserRepository : IUserRepository
    {
        private readonly CursoEfContext _CursoEfContext;

        public UserRepository(CursoEfContext context)
        {
            _CursoEfContext = context;
        }

        public async Task<List<User>>? GetAll()
            => await _CursoEfContext.users.ToListAsync();
        

        public async Task<User?> GetById(int id)
         => await _CursoEfContext.users
                .Include(a => a.WorkingExperiences)
                .FirstOrDefaultAsync(u => u.Id == id);


       
        public async Task<User?> Insert(User user)
        {
            EntityEntry<User> insertedEntity = await _CursoEfContext.users.AddAsync(user);
            return insertedEntity.Entity;
        }

        public void Update(User user)
        {
            _CursoEfContext.Update(user);
        }

        public void Delete(User user) { 
            _CursoEfContext.Remove(user); 
        }
    }
}
