using FluentNHibernate.Mapping;
using GGService2.DAL.Classes.Enums;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class HungerGamesRegistrationMap : ClassMap<HungerGamesRegistration>
  {
    public HungerGamesRegistrationMap()
    {
      this.Table("HungerGamesRegistration");
      this.Id((Expression<Func<HungerGamesRegistration, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<HungerGamesSeason>((Expression<Func<HungerGamesRegistration, HungerGamesSeason>>) (x => x.HungerGamesSeason)).Column("season_id").Not.LazyLoad();
      this.References<GameAccount>((Expression<Func<HungerGamesRegistration, GameAccount>>) (x => x.GameAccount)).Column("game_account_id").Not.LazyLoad();
      this.Map((Expression<Func<HungerGamesRegistration, object>>) (x => x.Hash)).Column("hash");
      this.Map((Expression<Func<HungerGamesRegistration, object>>) (x => (object) x.CreatedAt)).Column("created_at");
      this.Map((Expression<Func<HungerGamesRegistration, object>>) (x => (object) x.Status)).Column("status").CustomType<EHungerGamesRegistrationState>();
      this.Map((Expression<Func<HungerGamesRegistration, object>>) (x => (object) x.StatusChangedAt)).Column("status_changed_at");
      this.Map((Expression<Func<HungerGamesRegistration, object>>) (x => x.Owner)).Column("owner");
    }
  }
}
