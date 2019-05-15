using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class UserstatsMap : ClassMap<Userstats>
  {
    public UserstatsMap()
    {
      this.Table("UserStats");
      this.LazyLoad();
      this.Id((Expression<Func<Userstats, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.Map((Expression<Func<Userstats, object>>) (x => x.Owner)).Column("owner");
      this.Map((Expression<Func<Userstats, object>>) (x => (object) x.GamesTotal)).Column("games_total").Not.Nullable();
      this.Map((Expression<Func<Userstats, object>>) (x => (object) x.WinsTotal)).Column("wins_total").Not.Nullable();
    }
  }
}
