using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PROJECTNAME.Models
{
  public class PROJECTNAMEContext : DbContext
  {
    public virtual DbSet<PARENT> PARENTs { get; set; }
    public DbSet<CHILD> CHILDs { get; set; }
    public DbSet<PARENTCHILD> PARENTCHILD { get; set; }

    public PROJECTNAMEContext(DbContextOptions options) : base(options) { }
  }
}