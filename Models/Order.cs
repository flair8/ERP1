using ERP1.Models.Enums;
using System.Linq;

namespace ERP1.Models
{
    public class Order : Entity
    {
        private Order()
        {

        }

        public Order(int customerId)
        {
            Number = GenerateNumber();
            Status = EOrderStatus.Created;
            Items = new List<OrderItem>();
            Deliveries = new List<Delivery>();
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public Customer Customer { get; private set; } = null!;

        public string Number { get; private set; } = string.Empty;
        public ICollection<OrderItem> Items { get; private set; }
        public ICollection<Delivery> Deliveries { get; private set; }
        public EOrderStatus Status { get; private set; }

        public static string GenerateNumber()
        {
            return Guid.NewGuid()
               .ToString("N")
               .Substring(0, 8)
               .ToUpper();
        }

        public Result AddItem(Product product, decimal quantity)
        {
            var result = new Result();

            if (quantity <= 0)
                return Result.Failure(
                   nameof(CustomerId),
                   "Quantity mustt be greather than zero."
                );


            // Adiciona os orderItem para o order
            //_items.Add(orderItem);
        }

        public void AddDelivery(Delivery delivery)
        {
            // Adiciona os delivery para o order
            //_deliveries.Add(delivery);
        }

        public void PlaceOrder() { }
    }
}
