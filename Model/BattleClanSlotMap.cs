using FluentNHibernate.Mapping;
using GGService2.DAL.Classes.Enums;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class BattleClanSlotMap : ClassMap<BattleClanSlot>
  {
    public BattleClanSlotMap()
    {
      this.Table("BattleClanSlot");
      this.Id((Expression<Func<BattleClanSlot, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<Clan>((Expression<Func<BattleClanSlot, Clan>>) (x => x.Clan)).Column("clan_id").Not.LazyLoad();
      this.References<Battle>((Expression<Func<BattleClanSlot, Battle>>) (x => x.Battle)).Column("battle_id");
      this.Map((Expression<Func<BattleClanSlot, object>>) (x => (object) x.Side)).Column("side");
      this.Map((Expression<Func<BattleClanSlot, object>>) (x => (object) x.State)).Column("state").CustomType<EMemberState>();
    }
  }
}
