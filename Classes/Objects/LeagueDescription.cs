using GGService2.DAL.Classes.Enums;

namespace GGService2.DAL.Classes.Objects
{
  public class LeagueDescription
  {
    public ELeagueRank Rank { get; set; }

    public int Division { get; set; }

    public int? HighElo { get; set; }

    public int? LowElo { get; set; }

    public int Reward { get; set; }
  }
}
