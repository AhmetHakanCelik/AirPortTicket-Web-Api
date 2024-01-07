using Entities.Abstractions;

namespace Entities.Models
{
    public sealed class Customer:CustomerEntity
    { 
        public string CustomerName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public char Gender { get; set; }
        public string Email { get; set; } = null!;
        public int Phone { get; set; }
        public string Address { get; set; } = null!;
        public ICollection<Ticket>? Tickets { get; set; }
        public ICollection<Payment>? Payments { get; set; }
    }
}
