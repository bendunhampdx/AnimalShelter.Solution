using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Dog>()
            .HasData(
              new Dog { DogId = 1, Name = "Arlo", Breed = "Texas-Heeler", Gender = "male", Age = 1, Weight = 39, Description= "Arlo is a fun loving pup with a lot of energy."}
            );
          builder.Entity<Cat>()
            .HasData(
              new Cat { CatId = 1, Name = "Sam", Breed = "Main coon", Gender = "male", Age = 6, Weight = 15, Description= "Sam is an easy going boy. He loves to lounge around with people and chase lasers."}
            );
        }
        
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Cat> Cats { get; set; }
    }
}