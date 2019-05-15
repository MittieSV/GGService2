using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class BalanceMap : ClassMap<Balance>
  {
    public BalanceMap()
    {
      this.Table("Balance");
      this.LazyLoad();
      this.Id((Expression<Func<Balance, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.Map((Expression<Func<Balance, object>>) (x => x.Owner)).Column("owner");
      this.Map((Expression<Func<Balance, object>>) (x => (object) x.BalanceVal)).Column("balance");
    }
  }
}
