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
          builder.Entity<Animal>()
            .HasData(
              new Animal { AnimalId = 1, Name = "Arlo", Species = "dog", Breed = "Texas-Heeler", Gender = "male", Age = 1, Weight = 39, Description= "Arlo is a fun loving pup with a lot of energy."},
              new Animal { AnimalId = 2, Name = "Ollie", Species = "dog", Breed = "Lab", Gender = "female", Age = 3, Weight = 42, Description= "Ollie is a fun loving pup with a lot of energy."},
              new Animal { AnimalId = 3, Name = "Indigo", Species = "dog", Breed = "Pit-Bull", Gender = "male", Age = 6, Weight = 35, Description= "Indigo is a fun loving pup with a lot of energy."},
              new Animal { AnimalId = 4, Name = "Kermit", Species = "dog", Breed = "Corgi", Gender = "female", Age = 9, Weight = 24, Description= "Kermit is a fun loving pup with a lot of energy."},
              new Animal { AnimalId = 5, Name = "Danzig", Species = "dog", Breed = "Austrailian-Sheppard", Gender = "male", Age = 2, Weight = 26, Description= "Danzig is a fun loving pup with a lot of energy."},
              new Animal { AnimalId = 6, Name = "Sam", Species = "cat", Breed = "Main coon", Gender = "male", Age = 6, Weight = 15, Description= "Sam is an easy going boy. He loves to lounge around with people and chase lasers."},
              new Animal { AnimalId = 7, Name = "Fred", Species = "cat", Breed = "Bengal", Gender = "male", Age = 4, Weight = 13, Description= "Fred is an easy going boy. He loves to lounge around with people and chase lasers."},
              new Animal { AnimalId = 8, Name = "Lillie", Species = "cat", Breed = "Siberian", Gender = "female", Age = 2, Weight = 10, Description= "Lillie is an easy going gale. She loves to lounge around with people and chase lasers."},
              new Animal { AnimalId = 9, Name = "Barb", Species = "cat", Breed = "Ragdoll", Gender = "female", Age = 9, Weight = 9, Description= "Barb is an easy going gale. She loves to lounge around with people and chase lasers."},
              new Animal { AnimalId = 10, Name = "Rust", Species = "cat", Breed = "Siamese", Gender = "male", Age = 12, Weight = 15, Description= "Rust is an easy going boy. He loves to lounge around with people and chase lasers."}
            );
        }
        
        public DbSet<Animal> Animals { get; set; }
  
    }
}