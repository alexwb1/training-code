using System.Collections.Generic;
using System.Linq;
using PizzaPro.DataStore.Databases;
using PizzaPro.Domain.Models;

namespace PizzaPro.DataStore.Repositories
{
  public class Repository
  {
    private static readonly PizzaProDbContext _db = new PizzaProDbContext();

    public List<Model> Get(Model model)
    {
      return _db.model.ToList();
    }

    public Model Get(long id)
    {
      return _db.Crust.SingleOrDefault(x => x.ModelId == id); 
    }

    public bool Post(Model model)
    {
      _db.Model.Add(model);
      return _db.SaveChanges() == 1;
    }

    public bool Put(Model model)
    {
      Crust p = Get(model.ModelId);

      // p = Crust;
      return _db.SaveChanges() == 1;
    }
  }
}
