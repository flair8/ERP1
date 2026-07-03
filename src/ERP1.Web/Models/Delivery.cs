using ERP1.Models.Enums;

namespace ERP1.Models
{
    public class Delivery
    {
        public Delivery(DateTime estimatedDeliveryDate)
        {
            CreatedDate = DateTime.UtcNow;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }

        public DateTime CreatedDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public EDeliveryStatus Status { get; private set; }
    }
}
