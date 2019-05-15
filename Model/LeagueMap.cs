using FluentNHibernate.Mapping;
using GGService2.DAL.Classes.Enums;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class LeagueMap : ClassMap<League>
  {
    public LeagueMap()
    {
      this.Table("league");
      this.LazyLoad();
      this.Id((Expression<Func<League, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.Map((Expression<Func<League, object>>) (x => (object) x.Rank)).Column("rank").CustomType<ELeagueRank>();
      this.Map((Expression<Func<League, object>>) (x => (object) x.Division)).Column("division");
      this.Map((Expression<Func<League, object>>) (x => (object) x.MinElo)).Column("min_elo");
      this.Map((Expression<Func<League, object>>) (x => (object) x.MaxElo)).Column("max_elo");
      this.Map((Expression<Func<League, object>>) (x => (object) x.Reward)).Column("reward");
      this.Map((Expression<Func<League, object>>) (x => (object) x.PromoteLimit)).Column("promote_limit");
      this.Map((Expression<Func<League, object>>) (x => (object) x.NextPromotionTime)).Column("next_promotion_time");
    }
  }
}
