using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class GameAccountRandomMap : SubclassMap<GameAccountRandom>
  {
    public GameAccountRandomMap()
    {
      this.Table("GameAccountRandom");
      this.KeyColumn("gameAccount_id");
      this.Map((Expression<Func<GameAccountRandom, object>>) (x => x.Name)).Column("name");
    }
  }
}
