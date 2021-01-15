namespace PROJECTNAME.Models
{
  public class PARENTCHILD
  {
    public int PARENTCHILDId { get; set; }
    public int PARENTId { get; set; }
    public int CHILDId { get; set; }
    public Engineer PARENT { get; set; }
    public Machine CHILD { get; set; }
  }
}