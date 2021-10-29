using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Cat
  {
    public int CatId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }
    public string Description { get; set; }
  }
}