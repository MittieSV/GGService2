using FluentNHibernate.Mapping;
using GGService2.DAL.Classes.Enums;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class TournamentMap : ClassMap<Tournament>
  {
    public TournamentMap()
    {
      this.Table("Tournament");
      this.Id((Expression<Func<Tournament, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.Map((Expression<Func<Tournament, object>>) (x => x.Hash)).Column("hash");
      this.Map((Expression<Func<Tournament, object>>) (x => x.Name)).Column("name");
      this.References<Game>((Expression<Func<Tournament, Game>>) (x => x.Game)).Column("game_id").Not.LazyLoad();
      this.Map((Expression<Func<Tournament, object>>) (x => (object) x.Status)).Column("status").CustomType<EBattleStatus>();
      this.Map((Expression<Func<Tournament, object>>) (x => (object) x.BattleType)).Column("battleType").CustomType<EBattleType>();
      this.Map((Expression<Func<Tournament, object>>) (x => x.Parameters)).Column("parameters");
      this.Map((Expression<Func<Tournament, object>>) (x => (object) x.MembersAmount)).Column("membersAmount");
      this.Map((Expression<Func<Tournament, object>>) (x => (object) x.StartTime)).Column("start_time");
    }
  }
}
