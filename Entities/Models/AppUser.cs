using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class AppUser:IdentityUser<Guid>
    {
        public string? Username { get; set; }
        public int Password {  get; set; }
    }
}
