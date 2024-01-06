
using Entities.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public sealed class Bill:BillEntity
    {
        public Guid TicketId { get; set; }
        public int Identification_number { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerLastName { get; set;} = null!;
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }
        
    }
}
