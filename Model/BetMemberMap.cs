using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class BetMemberMap : ClassMap<BetMember>
  {
    public BetMemberMap()
    {
      this.Table("BetMember");
      this.Id((Expression<Func<BetMember, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<Bet>((Expression<Func<BetMember, Bet>>) (x => x.Bet)).Column("bet_id").Not.LazyLoad();
      this.Map((Expression<Func<BetMember, object>>) (x => x.Owner)).Column("owner");
      this.Map((Expression<Func<BetMember, object>>) (x => (object) x.Amount)).Column("amount");
    }
  }
}
