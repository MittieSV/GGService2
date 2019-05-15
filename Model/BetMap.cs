using FluentNHibernate.Mapping;
using GGService2.DAL.Classes.Enums;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class BetMap : ClassMap<Bet>
  {
    public BetMap()
    {
      this.Table("Bet");
      this.Id((Expression<Func<Bet, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.Map((Expression<Func<Bet, object>>) (x => x.Hash)).Column("hash");
      this.Map((Expression<Func<Bet, object>>) (x => x.BattleHash)).Column("battle_hash");
      this.Map((Expression<Func<Bet, object>>) (x => (object) x.Side)).Column("side");
      this.Map((Expression<Func<Bet, object>>) (x => (object) x.Status)).Column("status").CustomType<EBetStatus>();
    }
  }
}
