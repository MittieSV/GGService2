using GGService2.DAL.Classes.Objects;

namespace GGService2.DAL.Interfaces
{
  public interface IEloController
  {
    void SetElo(string userHash, int value);

    int GetElo(string userHash);

    LeagueDescription GetLeague(string userHash);

    void SetLeague(string userHash, LeagueDescription league);

    int GetEloPercentForGame(string gameShornName);
  }
}
