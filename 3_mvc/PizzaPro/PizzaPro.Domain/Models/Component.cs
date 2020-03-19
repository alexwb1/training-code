namespace PizzaPro.Domain.Models
{
  public class Component : Model
  {
    // private static readonly PizzaProDbContext _db = new PizzaProDbContext();

    public string Name { get; set; }
    public decimal Price { get; set; }
  }
}