using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace PierresInventory.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntries = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<TreatFlavor> JoinEntries { get; }

  }
}