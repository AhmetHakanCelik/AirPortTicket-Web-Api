namespace Entities.Abstractions
{
    public class CustomerEntity
    {
        public Guid CustomerId { get; set; }

        public CustomerEntity() 
        {
            CustomerId = Guid.NewGuid();
        }

    }
}
