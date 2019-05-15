using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class GameAccountCsgoMap : SubclassMap<GameAccountCsgo>
  {
    public GameAccountCsgoMap()
    {
      this.Table("GameAccountCSGO");
      this.KeyColumn("game_account_id");
      this.Map((Expression<Func<GameAccountCsgo, object>>) (x => (object) x.SteamId)).Column("SteamId");
      this.Map((Expression<Func<GameAccountCsgo, object>>) (x => (object) x.AccountId)).Column("AccountId");
      this.Map((Expression<Func<GameAccountCsgo, object>>) (x => x.Avatar)).Column("Avatar");
      this.Map((Expression<Func<GameAccountCsgo, object>>) (x => x.Name)).Column("Name");
    }
  }
}
