using System.Collections.Generic;
using System.Linq;
using PizzaPro.DataStore.Databases;
using PizzaPro.Domain.Models;

namespace PizzaPro.DataStore.Repositories
{
  public class CrustRepository
  {
    private static readonly PizzaProDbContext _db = new PizzaProDbContext();

    public List<Crust> Get()
    {
      return _db.Crust.ToList();
    }

    public Crust Get(long id)
    {
      return _db.Crust.SingleOrDefault(x => x.CrustId == id); 
    }

    public bool Post(Crust Crust)
    {
      _db.Crust.Add(Crust);
      return _db.SaveChanges() == 1;
    }

    public bool Put(Crust Crust)
    {
      Crust p = Get(Crust.CrustId);

      p = Crust;
      return _db.SaveChanges() == 1;
    }
  }
}
