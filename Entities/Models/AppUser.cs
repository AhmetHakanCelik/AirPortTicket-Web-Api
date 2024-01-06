using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class AppUser:IdentityUser<Guid>
    {
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
