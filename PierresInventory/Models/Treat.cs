using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace PierresInventory.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntries = new HashSet<TreatFlavor>();
    }

    public int TreatId { get; set; }
    public string TreatName { get; set; }
    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<TreatFlavor> JoinEntries { get; }

  }
}