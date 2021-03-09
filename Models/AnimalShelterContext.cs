// model that will allow us to interact with the database
// Every time we want to reference a database in an app, we will do so using an instance of this DbContext class.
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalContext(DbContextOptions options) : base(options) { }
  }
}