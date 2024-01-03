
namespace Entities.Models
{
    public sealed class Customer
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public char Gender { get; set; }
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public ICollection<Ticket>? Tickets { get; set; }
        public ICollection<Payment>? Payments { get; set; }
    }
}
