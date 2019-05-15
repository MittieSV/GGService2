using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class TournamentRegistrationMap : ClassMap<TournamentRegistration>
  {
    public TournamentRegistrationMap()
    {
      this.Table("TournamentRegistration");
      this.LazyLoad();
      this.Id((Expression<Func<TournamentRegistration, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<Tournament>((Expression<Func<TournamentRegistration, Tournament>>) (x => x.Tournament)).Column("tournament_id");
      this.References<GameAccount>((Expression<Func<TournamentRegistration, GameAccount>>) (x => x.GameAccount)).Column("game_account_id");
      this.Map((Expression<Func<TournamentRegistration, object>>) (x => (object) x.CreatedAt)).Column("created_at");
      this.Map((Expression<Func<TournamentRegistration, object>>) (x => x.Hash)).Column("hash");
    }
  }
}
