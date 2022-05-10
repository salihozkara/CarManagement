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
    
}