
using Entities.Abstractions;

namespace Entities.Models
{
    public sealed class Payment:PaymentEntity
    {
        public Guid CustomerId { get; set; }
        public int CardNumber { get; set; }    
        public string FullName { get; set; } = null!;
        public int SecurityCode { get; set; }
        public DateTime ExpirationDate { get; set; }

    }
}
