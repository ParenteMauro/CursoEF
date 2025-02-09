using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string Password { get; set; }
    }
}
