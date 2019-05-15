using FluentNHibernate.Mapping;
using GGService2.DAL.Classes.Enums;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class HungerGamesSessionMap : ClassMap<HungerGamesSession>
  {
    public HungerGamesSessionMap()
    {
      this.Table("hungergamessession");
      this.Id((Expression<Func<HungerGamesSession, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<HungerGamesSeason>((Expression<Func<HungerGamesSession, HungerGamesSeason>>) (x => x.HungerGamesSeason)).Column("season_id").Not.LazyLoad();
      this.References<Battle>((Expression<Func<HungerGamesSession, Battle>>) (x => x.Battle)).Column("battle_id").LazyLoad();
      this.Map((Expression<Func<HungerGamesSession, object>>) (x => x.Hash)).Column("hash");
      this.Map((Expression<Func<HungerGamesSession, object>>) (x => (object) x.Status)).Column("status").CustomType<ESessionStatus>();
      this.Map((Expression<Func<HungerGamesSession, object>>) (x => x.ActorPath)).Column("actor_path");
    }
  }
}
