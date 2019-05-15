namespace GGService2.DAL.Model
{
  public class BattleMemberClan : BattleMember
  {
    public virtual BattleClanSlot ClanSlot { get; set; }

    public virtual ClanMember ClanMember { get; set; }

    public override int Side
    {
      get
      {
        return this.ClanSlot.Side;
      }
    }
  }
}
