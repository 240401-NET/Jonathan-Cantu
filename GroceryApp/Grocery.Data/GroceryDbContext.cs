using Microsoft.EntityFrameworkCore;
using Grocery.Models;

namespace Grocery.Data;

public class GroceryDbContext : DbContext{
    public GroceryDbContext() : base(){}
    public GroceryDbContext(DbContextOptions options): base(options){}

    public DbSet<Item> Groceries{get;set;}
}