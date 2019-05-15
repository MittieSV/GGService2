using GGService2.DAL.Classes.Enums;

namespace GGService2.DAL.Model
{
  public class BattleMember
  {
    public virtual int Id { get; set; }

    public virtual GameAccount GameAccount { get; set; }

    public virtual Battle Battle { get; set; }

    public virtual string Hash { get; set; }

    public virtual int Side { get; set; }

    public virtual EMemberState State { get; set; }

    public virtual BattleMemberClan AsBattleMemberClan
    {
      get
      {
        return this as BattleMemberClan;
      }
    }

    public virtual BattleMemberSingle AsBattleMemberSingle
    {
      get
      {
        return this as BattleMemberSingle;
      }
    }
  }
}
