using ERP1.Models.Enums;

namespace ERP1.Models
{
    public class Ticket : Entity
    {
        public int CustomerId { get; private set; }
        public Customer Customer { get; set; } = null!;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ETicketStatus Status { get; set; }
        public ETicketPriority Priority { get; set; }
    }
}
