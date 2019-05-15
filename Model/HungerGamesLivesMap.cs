using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class HungerGamesLivesMap : ClassMap<HungerGamesLives>
  {
    public HungerGamesLivesMap()
    {
      this.Table("HungerGamesLives");
      this.LazyLoad();
      this.Id((Expression<Func<HungerGamesLives, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<HungerGamesSeason>((Expression<Func<HungerGamesLives, HungerGamesSeason>>) (x => x.HungerGamesSeason)).Column("hunger_games_id").Not.LazyLoad();
      this.Map((Expression<Func<HungerGamesLives, object>>) (x => x.Owner)).Column("owner");
      this.Map((Expression<Func<HungerGamesLives, object>>) (x => (object) x.Lives)).Column("lives");
    }
  }
}
