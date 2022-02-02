namespace ExercicioResolvidoSecao17.Entities;
internal class Products
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Products(string name, double price)
    {
        Name = name;
        Price = price;
    }
}
