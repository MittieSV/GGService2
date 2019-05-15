using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class HungerGamesMap : ClassMapping<HungerGames>
  {
    public HungerGamesMap()
    {
      this.Schema("hibernate");
      this.Lazy(true);
      this.Id<int>((Expression<Func<HungerGames, int>>) (x => x.Id), (Action<IIdMapper>) (map => map.Generator(Generators.Assigned)));
      this.Property<string>((Expression<Func<HungerGames, string>>) (x => x.Hash));
      this.Property<string>((Expression<Func<HungerGames, string>>) (x => x.State));
      this.Property<string>((Expression<Func<HungerGames, string>>) (x => x.Name));
      this.ManyToOne<HungerGamesSeason>((Expression<Func<HungerGames, HungerGamesSeason>>) (x => x.HungerGamesSeason), (Action<IManyToOneMapper>) (map =>
      {
        map.Column("season_id");
        map.NotNullable(true);
        map.Cascade(Cascade.None);
      }));
    }
  }
}
