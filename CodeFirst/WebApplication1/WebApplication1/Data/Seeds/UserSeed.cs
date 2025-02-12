using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Data.Entities;

namespace CodeFirst.Data.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
               (
                BuildUsers()
               );
        }

        public List<User> BuildUsers()
        {
            List<User> users = new List<User>();
            foreach(int index in Enumerable.Range(25,75))
            {
                users.Add(new User()
                {
                    Id = index,
                    Email = $"user{index}@gmail.com",
                    Password = "123",
                    UserName = $"user{index}"
                });
            }
            return users;
        }
    }
}
