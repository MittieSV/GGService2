using GGService2.DAL.Classes.Enums;

namespace GGService2.DAL.Model
{
  public class Bet
  {
    public virtual int Id { get; set; }

    public virtual string Hash { get; set; }

    public virtual string BattleHash { get; set; }

    public virtual int Side { get; set; }

    public virtual EBetStatus Status { get; set; }
  }
}
