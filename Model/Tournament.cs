using GGService2.DAL.Classes.Enums;

namespace GGService2.DAL.Model
{
  public class Tournament
  {
    public virtual int? Id { get; set; }

    public virtual string Hash { get; set; }

    public virtual Game Game { get; set; }

    public virtual string Name { get; set; }

    public virtual EBattleStatus Status { get; set; }

    public virtual EBattleType BattleType { get; set; }

    public virtual string Parameters { get; set; }

    public virtual int MembersAmount { get; set; }

    public virtual int StartTime { get; set; }
  }
}
