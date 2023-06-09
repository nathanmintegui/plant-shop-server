namespace PlantShop.Domain.Models;

public class Plant
{
    public Plant()
    {
    }

    public Plant(int id, string name, string image, decimal price, string description, GeneralCategory generalCategory,
        SpecificCategory specificCategory, bool isHotSale)
    {
        Id = id;
        Name = name;
        Image = image;
        Price = price;
        Description = description;
        GeneralCategory = generalCategory;
        SpecificCategory = specificCategory;
        IsHotSale = isHotSale;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Image { get; private set; }
    public decimal Price { get; private set; }
    public string Description { get; private set; }
    public GeneralCategory GeneralCategory { get; private set; }
    public SpecificCategory SpecificCategory { get; private set; }
    public bool IsHotSale { get; private set; }
}