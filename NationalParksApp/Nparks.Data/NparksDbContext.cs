using Microsoft.EntityFrameworkCore;
using Nparks.Models;

namespace Nparks.Data;

public class NparksDbContext : DbContext {
    public NparksDbContext() : base() {}
    public NparksDbContext(DbContextOptions options) : base(options) {}

    public DbSet<NationalPark> NationalPark { get; set; }
    public DbSet<BucketListPark> BucketListPark { get; set; }
    public DbSet<UserTable> UserTable { get; set;}

}