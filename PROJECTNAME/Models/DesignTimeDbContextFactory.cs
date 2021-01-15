using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PROJECTNAME.Models
{
  public class PROJECTNAMEContextFactory : IDesignTimeDbContextFactory<PROJECTNAMEContext>
  {

    PROJECTNAMEContext IDesignTimeDbContextFactory<PROJECTNAMEContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<PROJECTNAMEContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new PROJECTNAMEContext(builder.Options);
    }
  }
}