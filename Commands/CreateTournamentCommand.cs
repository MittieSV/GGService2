using GGService2.DAL.Classes.Enums;

namespace GGService2.DAL.Commands
{
  public class CreateTournamentCommand : BaseCommand
  {
    public string GameShortName { get; set; }

    public ETournamentType TournamentType { get; set; }

    public EBattleType BattleType { get; set; }

    public string JSONParam { get; set; }

    public int StartTime { get; set; }
  }
}
