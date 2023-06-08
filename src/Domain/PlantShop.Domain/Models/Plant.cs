namespace PlantShop.Domain.Models;

public class Plant
{
#pragma warning disable CS8618
    public Plant()
#pragma warning restore CS8618
    {
    }

    public Plant(int id, string name, string image, decimal price, string description, GeneralCategory generalCategory,
        SpecificCategory specificCategory)
    {
        Id = id;
        Name = name;
        Image = image;
        Price = price;
        Description = description;
        GeneralCategory = generalCategory;
        SpecificCategory = specificCategory;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Image { get; private set; }
    public decimal Price { get; private set; }
    public string Description { get; private set; }
    public GeneralCategory GeneralCategory { get; private set; }
    public SpecificCategory SpecificCategory { get; private set; }
}