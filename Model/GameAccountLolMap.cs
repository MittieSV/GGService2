using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class GameAccountLolMap : SubclassMap<GameAccountLol>
  {
    public GameAccountLolMap()
    {
      this.Table("GameAccountLol");
      this.KeyColumn("game_account_id");
      this.Map((Expression<Func<GameAccountLol, object>>) (x => x.Region)).Column("region");
      this.Map((Expression<Func<GameAccountLol, object>>) (x => x.SummonerName)).Column("summoner_name");
      this.Map((Expression<Func<GameAccountLol, object>>) (x => x.Avatar)).Column("avatar");
      this.Map((Expression<Func<GameAccountLol, object>>) (x => (object) x.LolId)).Column("lol_id");
    }
  }
}
