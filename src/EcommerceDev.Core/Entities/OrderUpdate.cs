namespace EcommerceDev.Core.Entities
{
    public class OrderUpdate : BaseEntity
    {
        public string Description { get; set; }
        public Guid IdOrder { get; set; }
    }
}