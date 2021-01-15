using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace PierresInventory.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<TreatFlavor>();
    }

    public int PROPERTYNAME { get; set; }
    public string PROPERTYNAME { get; set; }
    public string PROPERTYNAME { get; set; }
    public virtual ICollection<TreatFlavor> PROPERTYNAME { get; set; }

  }
}