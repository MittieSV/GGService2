using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class ServerCsgoQueueMap : ClassMap<ServerCsgoQueue>
  {
    public ServerCsgoQueueMap()
    {
      this.Table("ServerCSGOQueue");
      this.LazyLoad();
      this.Id((Expression<Func<ServerCsgoQueue, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<Battle>((Expression<Func<ServerCsgoQueue, Battle>>) (x => x.Battle)).Column("battle_id");
      this.Map((Expression<Func<ServerCsgoQueue, object>>) (x => (object) x.Priority)).Column("priority");
    }
  }
}
