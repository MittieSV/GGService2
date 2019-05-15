namespace GGService2.DAL.Model
{
  public class HungerGamesSessionMember
  {
    public virtual int Id { get; set; }

    public virtual GameAccount GameAccount { get; set; }

    public virtual HungerGamesSession HungerGamesSession { get; set; }

    public virtual HungerGamesRegistration HungerGamesRegistration { get; set; }
  }
}
