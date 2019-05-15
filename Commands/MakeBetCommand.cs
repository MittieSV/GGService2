namespace GGService2.DAL.Commands
{
  public class MakeBetCommand : BaseCommand
  {
    public string BattleHash { get; set; }

    public string Owner { get; set; }

    public double Amount { get; set; }

    public int Side { get; set; }
  }
}
