
namespace Entities.Models
{
    public sealed class Ticket
    {
        public Guid CustomerId { get; set; }
        public Guid TicketId { get; set; }
        public string? CustomerFullName { get; set; }
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }
        public Bill? Bill { get; set; }
    }
}
