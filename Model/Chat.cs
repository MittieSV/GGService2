namespace GGService2.DAL.Model
{
  public class Chat
  {
    public virtual int Id { get; set; }

    public virtual string Hash { get; set; }

    public virtual string From { get; set; }

    public virtual string To { get; set; }

    public virtual int? CreatedAt { get; set; }

    public virtual int? IsPublic { get; set; }

    public virtual string Message { get; set; }

    public virtual int? IsRead { get; set; }

    public virtual int? IsSystem { get; set; }
  }
}
