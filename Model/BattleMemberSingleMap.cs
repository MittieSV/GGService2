using FluentNHibernate.Mapping;

namespace GGService2.DAL.Model
{
  public class BattleMemberSingleMap : SubclassMap<BattleMemberSingle>
  {
    public BattleMemberSingleMap()
    {
      this.Table("BattleMemberSingle");
      this.KeyColumn("battle_member_id");
    }
  }
}
