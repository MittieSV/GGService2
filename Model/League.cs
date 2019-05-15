using GGService2.DAL.Classes.Enums;

namespace GGService2.DAL.Model
{
  public class League
  {
    public virtual int Id { get; set; }

    public virtual ELeagueRank Rank { get; set; }

    public virtual int Division { get; set; }

    public virtual int MinElo { get; set; }

    public virtual int MaxElo { get; set; }

    public virtual int Reward { get; set; }

    public virtual int PromoteLimit { get; set; }

    public virtual int NextPromotionTime { get; set; }
  }
}
