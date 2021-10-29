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
              new Dog { DogId = 1, Name = "Arlo", Breed = "Texas-Heeler", Gender = "male", Age = 1, Weight = 39, Description= "Arlo is a fun loving pup with a lot of energy."},
              new Dog { DogId = 2, Name = "Ollie", Breed = "Lab", Gender = "female", Age = 3, Weight = 42, Description= "Ollie is a fun loving pup with a lot of energy."},
              new Dog { DogId = 3, Name = "Indigo", Breed = "Pit-Bull", Gender = "male", Age = 6, Weight = 35, Description= "Indigo is a fun loving pup with a lot of energy."},
              new Dog { DogId = 4, Name = "Kermit", Breed = "Corgi", Gender = "female", Age = 9, Weight = 24, Description= "Kermit is a fun loving pup with a lot of energy."},
              new Dog { DogId = 5, Name = "Danzig", Breed = "Austrailian-Sheppard", Gender = "male", Age = 2, Weight = 26, Description= "Danzig is a fun loving pup with a lot of energy."}
            );
          builder.Entity<Cat>()
            .HasData(
              new Cat { CatId = 1, Name = "Sam", Breed = "Main coon", Gender = "male", Age = 6, Weight = 15, Description= "Sam is an easy going boy. He loves to lounge around with people and chase lasers."},
              new Cat { CatId = 2, Name = "Fred", Breed = "Bengal", Gender = "male", Age = 4, Weight = 13, Description= "Fred is an easy going boy. He loves to lounge around with people and chase lasers."},
              new Cat { CatId = 3, Name = "Lillie", Breed = "Siberian", Gender = "female", Age = 2, Weight = 10, Description= "Lillie is an easy going gale. She loves to lounge around with people and chase lasers."},
              new Cat { CatId = 4, Name = "Barb", Breed = "Ragdoll", Gender = "female", Age = 9, Weight = 9, Description= "Barb is an easy going gale. She loves to lounge around with people and chase lasers."},
              new Cat { CatId = 5, Name = "Rust", Breed = "Siamese", Gender = "male", Age = 12, Weight = 15, Description= "Rust is an easy going boy. He loves to lounge around with people and chase lasers."}

            );
        }
        
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Cat> Cats { get; set; }
    }
}