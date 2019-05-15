namespace GGService2.DAL.Model
{
  public class Clan
  {
    public virtual int Id { get; set; }

    public virtual string Hash { get; set; }

    public virtual string Name { get; set; }

    public virtual int IsDeleted { get; set; }
  }
}
