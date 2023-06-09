namespace PlantShop.Domain.Models;

public class Services
{
#pragma warning disable CS8618
    public Services()
#pragma warning restore CS8618
    {
    }

    public Services(int id, string name, string description, string image, decimal price,
        GeneralCategory generalCategory)
    {
        Id = id;
        Name = name;
        Description = description;
        Image = image;
        Price = price;
        GeneralCategory = generalCategory;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string Image { get; private set; }
    public decimal Price { get; private set; }
    public GeneralCategory GeneralCategory { get; private set; }
}