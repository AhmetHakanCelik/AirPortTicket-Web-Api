
namespace Entities.Models
{
    public sealed class Bill
    {
        public Guid PaymentId { get; set; }
        public int Identification_number { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerLastName { get; set;} = null!;
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }
        
    }
}
