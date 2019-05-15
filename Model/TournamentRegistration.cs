namespace GGService2.DAL.Model
{
  public class TournamentRegistration
  {
    public virtual int Id { get; set; }

    public virtual Tournament Tournament { get; set; }

    public virtual GameAccount GameAccount { get; set; }

    public virtual string Hash { get; set; }

    public virtual int? CreatedAt { get; set; }
  }
}
