using FluentNHibernate.Mapping;
using GGService2.DAL.Classes.Enums;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class BattleMap : ClassMap<Battle>
  {
    public BattleMap()
    {
      this.Table("Battle");
      this.Id((Expression<Func<Battle, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<Game>((Expression<Func<Battle, Game>>) (x => x.Game)).Column("game_id").Not.LazyLoad();
      this.Map((Expression<Func<Battle, object>>) (x => x.Hash)).Column("hash");
      this.Map((Expression<Func<Battle, object>>) (x => (object) x.Status)).Column("status").CustomType<EBattleStatus>();
      this.Map((Expression<Func<Battle, object>>) (x => (object) x.BattleType)).Column("battle_type").CustomType<EBattleType>();
      this.Map((Expression<Func<Battle, object>>) (x => (object) x.StartTime)).Column("start_time");
      this.Map((Expression<Func<Battle, object>>) (x => (object) x.PublicAccess)).Column("public_access");
      this.Map((Expression<Func<Battle, object>>) (x => x.Owner)).Column("owner");
      this.Map((Expression<Func<Battle, object>>) (x => (object) x.IsDirect)).Column("isDirect");
      this.Map((Expression<Func<Battle, object>>) (x => x.ActorPath)).Column("actorPath");
      this.Map((Expression<Func<Battle, object>>) (x => (object) x.Stake)).Column("stake");
      this.Map((Expression<Func<Battle, object>>) (x => x.StartLink)).Column("start_link");
      this.Map((Expression<Func<Battle, object>>) (x => x.StartParameters)).Column("start_parameters");
      this.Map((Expression<Func<Battle, object>>) (x => (object) x.CreatedAt)).Column("created_at");
      this.HasOne<ServerCsgo>((Expression<Func<Battle, ServerCsgo>>) (x => x.Server));
    }
  }
}
