using GGService2.DAL.Classes.Enums;

namespace GGService2.DAL.Model
{
  public class Battle
  {
    private EBattleStatus _status;

    public virtual int Id { get; set; }

    public virtual Game Game { get; set; }

    public virtual string Hash { get; set; }

    public virtual EBattleStatus Status
    {
      get
      {
        return this._status;
      }
      set
      {
        this._status = value;
      }
    }

    public virtual EBattleType BattleType { get; set; }

    public virtual int StartTime { get; set; }

    public virtual int PublicAccess { get; set; }

    public virtual string Owner { get; set; }

    public virtual int IsDirect { get; set; }

    public virtual string ActorPath { get; set; }

    public virtual double Stake { get; set; }

    public virtual string StartLink { get; set; }

    public virtual string StartParameters { get; set; }

    public virtual int CreatedAt { get; set; }

    public virtual ServerCsgo Server { get; set; }

    public virtual BattleSingle AsBattleSingle
    {
      get
      {
        return this as BattleSingle;
      }
    }

    public virtual BattleClan AsBattleClan
    {
      get
      {
        return this as BattleClan;
      }
    }
  }
}
