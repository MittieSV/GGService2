namespace GGService2.DAL.Commands
{
  public class BaseBattleCommand : BaseCommand
  {
    public string GameShortName { get; set; }

    public string Hash { get; set; }

    public bool IsDirect { get; set; }
  }
}
