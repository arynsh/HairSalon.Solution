using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
   //DBSet Stylist refers to the stylist table in database and Stylists is a variable that the table is set to
    public virtual DbSet<Stylist> Stylists { get; set; }
   
   // /DBSet Client refers to the client table in database and and Clients is a variable that the table is set to
    public DbSet<Client> Clients { get; set; }
    public HairSalonContext(DbContextOptions options) : base(options) { }
  }
}