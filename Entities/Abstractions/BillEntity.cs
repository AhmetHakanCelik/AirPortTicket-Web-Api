namespace Entities.Abstractions
{
    public class BillEntity
    {
        public Guid PaymentId { get; set; }

        public BillEntity() 
        {
            PaymentId = Guid.NewGuid();
        }

    }
}
