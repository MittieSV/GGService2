using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class ClanMemberMap : ClassMap<ClanMember>
  {
    public ClanMemberMap()
    {
      this.Table("ClanMember");
      this.LazyLoad();
      this.Id((Expression<Func<ClanMember, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.References<Clan>((Expression<Func<ClanMember, Clan>>) (x => x.Clan)).Column("clan_id");
      this.References<GameAccount>((Expression<Func<ClanMember, GameAccount>>) (x => x.GameAccount)).Column("game_account_id");
      this.Map((Expression<Func<ClanMember, object>>) (x => (object) x.IsLeader)).Column("is_leader");
      this.Map((Expression<Func<ClanMember, object>>) (x => (object) x.Confirmed)).Column("confirmed");
    }
  }
}
