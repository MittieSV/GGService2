using FluentNHibernate.Mapping;

namespace GGService2.DAL.Model
{
  public class BattleClanMap : SubclassMap<BattleClan>
  {
    public BattleClanMap()
    {
      this.Table("BattleClan");
      this.KeyColumn("battle_id");
    }
  }
}
