namespace GGService2.DAL.Model
{
  public class HungerGamesElo
  {
    public virtual int Id { get; set; }

    public virtual League League { get; set; }

    public virtual string Owner { get; set; }

    public virtual int Elo { get; set; }
  }
}
