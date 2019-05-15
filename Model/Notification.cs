namespace GGService2.DAL.Model
{
  public class Notification
  {
    public virtual int Id { get; set; }

    public virtual string Hash { get; set; }

    public virtual string Owner { get; set; }

    public virtual string Params { get; set; }

    public virtual int? CreatedAt { get; set; }

    public virtual string Message { get; set; }

    public virtual string Class { get; set; }

    public virtual int? Type { get; set; }

    public virtual int? Buttons { get; set; }

    public virtual int? IsRead { get; set; }

    public virtual int? Answer { get; set; }
  }
}
