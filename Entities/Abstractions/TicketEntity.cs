namespace Entities.Abstractions
{
    public class TicketEntity
    {
        public Guid TicketId { get; set; }

        public TicketEntity()
        {
            TicketId = Guid.NewGuid();
        }
    }
}
