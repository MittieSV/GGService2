using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class GameAccountMap : ClassMap<GameAccount>
  {
    public GameAccountMap()
    {
      this.Table("GameAccount");
      this.Id((Expression<Func<GameAccount, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<Game>((Expression<Func<GameAccount, Game>>) (x => x.Game)).Column("game_id").Not.LazyLoad();
      this.Map((Expression<Func<GameAccount, object>>) (x => x.Hash)).Column("hash");
      this.Map((Expression<Func<GameAccount, object>>) (x => x.Owner)).Column("owner");
      this.Map((Expression<Func<GameAccount, object>>) (x => x.Preview)).Column("preview");
      this.Map((Expression<Func<GameAccount, object>>) (x => x.Avatar)).Column("avatar");
      this.Map((Expression<Func<GameAccount, object>>) (x => (object) x.Hidden)).Column("hidden");
    }
  }
}
