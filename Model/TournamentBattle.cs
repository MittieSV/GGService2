namespace GGService2.DAL.Model
{
  public class TournamentBattle
  {
    public virtual int Id { get; set; }

    public virtual Battle Battle { get; set; }

    public virtual Battle ParentBattle1 { get; set; }

    public virtual Battle ParentBattle2 { get; set; }

    public virtual Tournament Touranment { get; set; }
  }
}
