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
               new User() { Id = 1, Email = "user1@gmail.com", UserName = "user1", Password = "123" },
               new User() { Id = 2, Email = "user2@gmail.com", UserName = "user2", Password = "123" }
               );
        }
    }
}
