namespace ERP1.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public DateTime? UpdatedAt { get; private set; }

        public void MarkAsUpdated()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
