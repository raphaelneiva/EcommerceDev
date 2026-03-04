namespace EcommerceDev.Core.Entities;

public class ProductCategory : BaseEntity
{
    protected ProductCategory(){}
    public ProductCategory(string title, string subcategory)
    {
        Title = title;
        Subcategory = subcategory;
    }

    public string Title { get; set; }
    public string Subcategory { get; set; }
    public List<Product> Products { get; set; } = [];
}