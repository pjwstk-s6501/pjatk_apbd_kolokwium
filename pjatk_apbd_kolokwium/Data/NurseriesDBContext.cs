using Microsoft.EntityFrameworkCore;
using pjatk_apbd_kolokwium.Models;

namespace pjatk_apbd_kolokwium.Data;

public class NurseriesDbContext : DbContext
{
    public NurseriesDbContext(DbContextOptions<NurseriesDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=apbd_local.db");
    }
    
    public DbSet<Employee> Employees { set; get; }
    public DbSet<Nursery> Nurseries { set; get; }
    public DbSet<Responsible> Responsibles { set; get; }
    public DbSet<SeedingBatch> SeedingBatches { set; get; }
    public DbSet<TreeSpecies> TreeSpecies { set; get; }
}