using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class ClanMap : ClassMap<Clan>
  {
    public ClanMap()
    {
      this.Table("Clan");
      this.Id((Expression<Func<Clan, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.Map((Expression<Func<Clan, object>>) (x => x.Hash)).Column("hash");
      this.Map((Expression<Func<Clan, object>>) (x => x.Name)).Column("name");
      this.Map((Expression<Func<Clan, object>>) (x => (object) x.IsDeleted)).Column("is_deleted");
    }
  }
}
