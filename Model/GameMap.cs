using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class GameMap : ClassMap<Game>
  {
    public GameMap()
    {
      this.Table("Game");
      this.Id((Expression<Func<Game, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.Map((Expression<Func<Game, object>>) (x => x.Name)).Column("name");
      this.Map((Expression<Func<Game, object>>) (x => x.ShortName)).Column("short_name");
      this.Map((Expression<Func<Game, object>>) (x => (object) x.Active)).Column("active");
      this.Map((Expression<Func<Game, object>>) (x => x.Module)).Column("module");
      this.Map((Expression<Func<Game, object>>) (x => x.ControllerPath)).Column("controller_path");
      this.Map((Expression<Func<Game, object>>) (x => (object) x.EloPercent)).Column("elo_percent");
      this.Map((Expression<Func<Game, object>>) (x => (object) x.GiveUpMins)).Column("give_up_mins");
    }
  }
}
