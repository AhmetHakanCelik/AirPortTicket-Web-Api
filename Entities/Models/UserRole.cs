namespace Entities.Models
{
    public sealed class UserRole
    {
        public Guid UserId { get; set; }
        public AppUser User { get; set; }

        public Guid RoleId { get; set; }
        public AppRole Role { get; set; }
    }
}
