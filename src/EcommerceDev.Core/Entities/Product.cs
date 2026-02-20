namespace EcommerceDev.Core.Entities
{
    public class Product : BaseEntity
    {
        public Product(string title, string description, string price, string brand, int quantity, Guid idCategory)
        {
            Title = title;
            Description = description;
            Price = price;
            Brand = brand;
            Quantity = quantity;
            IdCategory = idCategory;
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        public string Brand { get; set; }

        public int Quantity { get; set; }

        public Guid IdCategory { get; set; }

        public ProductCategory Category { get; set; }
    }
}