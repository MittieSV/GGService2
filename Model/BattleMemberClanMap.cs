using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class BattleMemberClanMap : SubclassMap<BattleMemberClan>
  {
    public BattleMemberClanMap()
    {
      this.Table("BattleMemberClan");
      this.KeyColumn("battle_member_id");
      this.References<BattleClanSlot>((Expression<Func<BattleMemberClan, BattleClanSlot>>) (x => x.ClanSlot)).Column("clan_slot_id");
      this.References<ClanMember>((Expression<Func<BattleMemberClan, ClanMember>>) (x => x.ClanMember)).Column("clan_member_id");
    }
  }
}
