using FluentNHibernate.Mapping;
using GGService2.DAL.Classes.Enums;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class BattleMemberMap : ClassMap<BattleMember>
  {
    public BattleMemberMap()
    {
      this.Table("BattleMember");
      this.HibernateMapping.DefaultCascade.None();
      this.Id((Expression<Func<BattleMember, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<GameAccount>((Expression<Func<BattleMember, GameAccount>>) (x => x.GameAccount)).Column("game_account_id").Not.LazyLoad();
      this.References<Battle>((Expression<Func<BattleMember, Battle>>) (x => x.Battle)).Column("battle_id").Cascade.None();
      this.Map((Expression<Func<BattleMember, object>>) (x => x.Hash)).Column("hash");
      this.Map((Expression<Func<BattleMember, object>>) (x => (object) x.Side)).Column("side");
      this.Map((Expression<Func<BattleMember, object>>) (x => (object) x.State)).Column("State").CustomType<EMemberState>();
    }
  }
}
