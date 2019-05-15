using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class ProcessorResultsMap : ClassMap<ProcessorResults>
  {
    public ProcessorResultsMap()
    {
      this.Table("processorResults");
      this.LazyLoad();
      this.Id((Expression<Func<ProcessorResults, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.Map((Expression<Func<ProcessorResults, object>>) (x => x.Token)).Column("token");
      this.Map((Expression<Func<ProcessorResults, object>>) (x => x.Game)).Column("game");
      this.Map((Expression<Func<ProcessorResults, object>>) (x => x.Status)).Column("status");
      this.Map((Expression<Func<ProcessorResults, object>>) (x => x.Description)).Column("description");
    }
  }
}
