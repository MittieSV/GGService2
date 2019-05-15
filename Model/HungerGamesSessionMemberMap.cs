using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class HungerGamesSessionMemberMap : ClassMap<HungerGamesSessionMember>
  {
    public HungerGamesSessionMemberMap()
    {
      this.Table("HungerGamesSessionMember");
      this.Id((Expression<Func<HungerGamesSessionMember, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<GameAccount>((Expression<Func<HungerGamesSessionMember, GameAccount>>) (x => x.GameAccount)).Column("game_account_id").Not.LazyLoad();
      this.References<HungerGamesSession>((Expression<Func<HungerGamesSessionMember, HungerGamesSession>>) (x => x.HungerGamesSession)).Column("session_id").Not.LazyLoad();
      this.References<HungerGamesRegistration>((Expression<Func<HungerGamesSessionMember, HungerGamesRegistration>>) (x => x.HungerGamesRegistration)).Column("registration_id").Not.LazyLoad();
    }
  }
}
