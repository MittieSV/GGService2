namespace GGService2.DAL.Model
{
  public class BetMember
  {
    public virtual int Id { get; set; }

    public virtual Bet Bet { get; set; }

    public virtual string Owner { get; set; }

    public virtual double Amount { get; set; }
  }
}
