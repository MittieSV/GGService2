namespace GGService2.DAL.Model
{
  public class ProcessorResults
  {
    public virtual int Id { get; set; }

    public virtual string Token { get; set; }

    public virtual string Game { get; set; }

    public virtual string Status { get; set; }

    public virtual string Description { get; set; }
  }
}
