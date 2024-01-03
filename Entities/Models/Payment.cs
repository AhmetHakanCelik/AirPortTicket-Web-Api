
namespace Entities.Models
{
    public sealed class Payment
    {
        public Guid CardNumber { get; set; }
        public Guid CustomerId { get; set; }
        public string FullName { get; set; } = null!;
        public int SecurityCode { get; set; }
        public DateTime ExpirationDate { get; set; }

    }
}
