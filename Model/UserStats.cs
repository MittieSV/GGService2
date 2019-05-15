namespace GGService2.DAL.Model
{
  public class Userstats
  {
    public virtual int Id { get; set; }

    public virtual string Owner { get; set; }

    public virtual int GamesTotal { get; set; }

    public virtual int WinsTotal { get; set; }
  }
}
