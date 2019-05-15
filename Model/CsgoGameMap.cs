using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class CsgoGameMap : ClassMap<CsgoGame>
  {
    public CsgoGameMap()
    {
      this.Table("CSGOGame");
      this.LazyLoad();
      this.Id((Expression<Func<CsgoGame, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<Battle>((Expression<Func<CsgoGame, Battle>>) (x => x.Battle)).Column("battle_id");
      this.References<ServerCsgo>((Expression<Func<CsgoGame, ServerCsgo>>) (x => x.ServerCsgo)).Column("server_id");
      this.Map((Expression<Func<CsgoGame, object>>) (x => x.Map)).Column("map");
      this.Map((Expression<Func<CsgoGame, object>>) (x => (object) x.ScoreLimit)).Column("score_limit");
    }
  }
}
