using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class TransactionMap : ClassMap<Transaction>
  {
    public TransactionMap()
    {
      this.Table("`Transaction`");
      this.LazyLoad();
      this.Id((Expression<Func<Transaction, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.Map((Expression<Func<Transaction, object>>) (x => x.From)).Column("`from`");
      this.Map((Expression<Func<Transaction, object>>) (x => x.To)).Column("`to`");
      this.Map((Expression<Func<Transaction, object>>) (x => (object) x.Amount)).Column("amount");
    }
  }
}
