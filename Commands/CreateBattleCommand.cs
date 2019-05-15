using GGService2.DAL.Classes.Enums;

namespace GGService2.DAL.Commands
{
  public class CreateBattleCommand : BaseBattleCommand
  {
    public string Owner { get; set; }

    public EBattleType BattleType { get; set; }

    public int StartTime { get; set; }

    public double Stake { get; set; }

    public string JSONParam { get; set; }
  }
}
