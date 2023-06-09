namespace PlantShop.Domain.Models;

public class Planter
{
    public Planter(int id, string name, string image, decimal price, string description)
    {
        Id = id;
        Name = name;
        Image = image;
        Price = price;
        Description = description;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Image { get; private set; }
    public decimal Price { get; private set; }
    public string Description { get; private set; }
}