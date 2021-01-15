using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace PROJECTNAME.Models
{
  public class PARENT
  {
    public PARENT()
    {
      this.CHILDs = new HashSet<PARENTCHILD>();
    }

    public int PROPERTYNAME { get; set; }
    public string PROPERTYNAME { get; set; }
    public string PROPERTYNAME { get; set; }
    public virtual ICollection<PARENTCHILD> PROPERTYNAME { get; set; }

  }
}