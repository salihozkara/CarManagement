using Entities.Concrete;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class CarContext: DbContext
{
    public CarContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=cars.db");
    }
    
    public DbSet<Car> Cars { get; set; }

    public DbSet<CarType> CarTypes { get; set; }

    public DbSet<Maintain> Maintains { get; set; }

    public DbSet<MaintainType> MaintainTypes { get; set; }

    public DbSet<Transaction> Transactions { get; set; }


}