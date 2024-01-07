using Entities.Abstractions;

namespace Entities.Models
{
    public sealed class Ticket:TicketEntity
    {
        public Guid CustomerId { get; set; }
        public string? CustomerFullName { get; set; }
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }
        public Bill? Bill { get; set; }
    }
}
