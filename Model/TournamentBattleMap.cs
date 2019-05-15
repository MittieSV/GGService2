using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class TournamentBattleMap : ClassMap<TournamentBattle>
  {
    public TournamentBattleMap()
    {
      this.Table("TournamentBattle");
      this.LazyLoad();
      this.Id((Expression<Func<TournamentBattle, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<Battle>((Expression<Func<TournamentBattle, Battle>>) (x => x.Battle)).Column("battle_id");
      this.References<Battle>((Expression<Func<TournamentBattle, Battle>>) (x => x.ParentBattle1)).Column("parent_battle_id1");
      this.References<Battle>((Expression<Func<TournamentBattle, Battle>>) (x => x.ParentBattle2)).Column("parent_battle_id2");
      this.References<Tournament>((Expression<Func<TournamentBattle, Tournament>>) (x => x.Touranment)).Column("touranment_id");
    }
  }
}
