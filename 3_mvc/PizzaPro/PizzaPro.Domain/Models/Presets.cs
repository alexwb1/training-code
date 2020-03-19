namespace PizzaPro.Domain.Models
{
  public static class Presets
  {
    private static System.Collections.Generic.List<Pizza> presets = new System.Collections.Generic.List<Pizza>();
    public Presets()
    {
      presets.Add(new Pizza());
    }


  }
}