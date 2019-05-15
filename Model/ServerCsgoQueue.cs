namespace GGService2.DAL.Model
{
  public class ServerCsgoQueue
  {
    public virtual int Id { get; set; }

    public virtual Battle Battle { get; set; }

    public virtual int? Priority { get; set; }
  }
}
