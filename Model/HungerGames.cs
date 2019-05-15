namespace GGService2.DAL.Model
{
  public class HungerGames
  {
    public virtual int Id { get; set; }

    public virtual HungerGamesSeason HungerGamesSeason { get; set; }

    public virtual string Hash { get; set; }

    public virtual string State { get; set; }

    public virtual string Name { get; set; }
  }
}
