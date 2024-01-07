namespace Entities.Abstractions
{
    public class PaymentEntity
    {
        public Guid CardId { get; set; }

        public PaymentEntity() 
        { 
            CardId = Guid.NewGuid();
        }
    }
}
