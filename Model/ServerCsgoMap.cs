using FluentNHibernate.Mapping;
using GGService2.DAL.Classes.Enums;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class ServerCsgoMap : ClassMap<ServerCsgo>
  {
    public ServerCsgoMap()
    {
      this.Table("ServerCSGO");
      this.LazyLoad();
      this.Id((Expression<Func<ServerCsgo, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<Battle>((Expression<Func<ServerCsgo, Battle>>) (x => x.Battle)).Column("battle_id");
      this.Map((Expression<Func<ServerCsgo, object>>) (x => x.Address)).Column("address");
      this.Map((Expression<Func<ServerCsgo, object>>) (x => (object) x.Port)).Column("port");
      this.Map((Expression<Func<ServerCsgo, object>>) (x => x.RconPassword)).Column("rcon_password");
      this.Map((Expression<Func<ServerCsgo, object>>) (x => x.SshUser)).Column("ssh_user");
      this.Map((Expression<Func<ServerCsgo, object>>) (x => x.SshPassword)).Column("ssh_password");
      this.Map((Expression<Func<ServerCsgo, object>>) (x => (object) x.Status)).Column("status").CustomType<EServerStatus>();
    }
  }
}
