using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class HungerGamesEloMap : ClassMap<HungerGamesElo>
  {
    public HungerGamesEloMap()
    {
      this.Table("hungergameselo");
      this.LazyLoad();
      this.Id((Expression<Func<HungerGamesElo, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<League>((Expression<Func<HungerGamesElo, League>>) (x => x.League)).Column("league_id");
      this.Map((Expression<Func<HungerGamesElo, object>>) (x => x.Owner)).Column("owner");
      this.Map((Expression<Func<HungerGamesElo, object>>) (x => (object) x.Elo)).Column("elo");
    }
  }
}
