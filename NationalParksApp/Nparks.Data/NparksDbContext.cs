using Microsoft.EntityFrameworkCore;
using Nparks.Models;

namespace Nparks.Data;

public class NparksDbContext : DbContext {
    public NparksDbContext() : base() {}
    public NparksDbContext(DbContextOptions options) : base(options) {}

    public DbSet<nationalParks> nationalParks { get; set; }
    public DbSet<BucketListParks> BucketListParks { get; set; }
    public DbSet<UserTable> UserTable { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
     modelBuilder.Entity<BucketListParks>().HasNoKey();
    modelBuilder.Entity<UserTable>().HasNoKey();
     modelBuilder.Entity<nationalParks>().HasNoKey();

 }



}