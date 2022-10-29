using BusinessStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BusinessStore.Data;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    
    public virtual DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
    public virtual DbSet<Brand> Brands { get; set; }
    public virtual DbSet<ContactPerson> ContactPeople { get; set; }
    public virtual DbSet<Country> Countries { get; set; }
    public virtual DbSet<Partner> Partners { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<ProductCategory> ProductCategories { get; set; }
    public virtual DbSet<Region> Regions { get; set; }
    public virtual DbSet<Store> Stores { get; set; }
    public virtual DbSet<StoreGroup> StoreGroups { get; set; }
    public virtual DbSet<StoreProduct> StoreProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string connectionString = "server=localhost;user=root;password=12345678;database=usersdb5;";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
