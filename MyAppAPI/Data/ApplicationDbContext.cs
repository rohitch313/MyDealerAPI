using Microsoft.EntityFrameworkCore;
using MyAppAPI.Model;

namespace MyAppAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

  public DbSet<Car> Cars { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Sample> Samples { get; set; }
        public DbSet<BankDetail>BankDetails{ get; set; }
        public DbSet<Vehiclerecord> VehicleRecords { get; set; }
        public DbSet<ProcurementFilter> ProcurementFilters { get; set;}
        public DbSet<ProcDetails>procDetails { get; set; }
        public DbSet<StockAudit>StockAudits{ get; set; }

    }
}
