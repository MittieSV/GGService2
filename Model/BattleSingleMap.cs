using FluentNHibernate.Mapping;

namespace GGService2.DAL.Model
{
  public class BattleSingleMap : SubclassMap<BattleSingle>
  {
    public BattleSingleMap()
    {
      this.Table("BattleSingle");
    }
  }
}
