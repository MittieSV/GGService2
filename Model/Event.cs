namespace GGService2.DAL.Model
{
  public class Event
  {
    public virtual int Id { get; set; }

    public virtual string Subscriber { get; set; }

    public virtual string Raiser { get; set; }

    public virtual string Name { get; set; }

    public virtual string Method { get; set; }
  }
}
