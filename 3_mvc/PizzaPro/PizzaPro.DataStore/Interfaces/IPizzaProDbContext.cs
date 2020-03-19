using PizzaPro.DataStore.DatabaseContext;
namespace PizzaPro.DataStore.Interfaces
{
  public interface IPizzaProDbContext
  {
    private static readonly PizzaProDbContext _db = new PizzaProDbContext();
  }
}