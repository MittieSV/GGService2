using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class HungerGamesSeasonMap : ClassMap<HungerGamesSeason>
  {
    public HungerGamesSeasonMap()
    {
      this.Table("HungerGamesSeason");
      this.LazyLoad();
      this.Id((Expression<Func<HungerGamesSeason, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<Game>((Expression<Func<HungerGamesSeason, Game>>) (x => x.Game)).Column("game_id").Not.LazyLoad();
      this.Map((Expression<Func<HungerGamesSeason, object>>) (x => x.Hash)).Column("hash");
      this.Map((Expression<Func<HungerGamesSeason, object>>) (x => x.Name)).Column("name");
      this.Map((Expression<Func<HungerGamesSeason, object>>) (x => x.DefaultParameters)).Column("defaultParameters");
      this.Map((Expression<Func<HungerGamesSeason, object>>) (x => (object) x.Active)).Column("active");
      this.Map((Expression<Func<HungerGamesSeason, object>>) (x => (object) x.Price)).Column("price");
      this.Map((Expression<Func<HungerGamesSeason, object>>) (x => (object) x.LivesAmount)).Column("livesAmount");
    }
  }
}
