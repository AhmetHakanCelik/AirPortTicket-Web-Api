
namespace Entities.Models
{
    public sealed class Customer
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
        public ICollection<Payment>? Payments { get; set; }
    }
}
