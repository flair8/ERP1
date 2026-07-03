namespace ERP1.Models
{
    public class OrderItem
    {
        public OrderItem(Product product, decimal quantity)
        {
            Product = product;
            Price = product.Price;
            Quantity = quantity;
        }

        public Product Product { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal Price { get; private set; }


    }
}
