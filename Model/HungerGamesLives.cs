namespace GGService2.DAL.Model
{
  public class HungerGamesLives
  {
    public virtual int Id { get; set; }

    public virtual HungerGamesSeason HungerGamesSeason { get; set; }

    public virtual string Owner { get; set; }

    public virtual int Lives { get; set; }
  }
}
