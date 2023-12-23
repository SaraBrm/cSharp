public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public int Price { get; set; }

    public Product(int id, string name,
        string model, int price)
    {
        Id = id;
        Name = name;
        Model = model;
        Price = price;
    }
}
