using Microsoft.EntityFrameworkCore;
namespace Grocery.Models;

public class GroceryDbContext : DbContext{
    public GroceryDbContext() : base(){}
    public GroceryDbContext(DbContextOptions options): base(options){}

    public DbSet<Grocery> Groceries{get;set;}
}