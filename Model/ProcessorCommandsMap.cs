using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class ProcessorCommandsMap : ClassMap<ProcessorCommands>
  {
    public ProcessorCommandsMap()
    {
      this.Table("processorCommands");
      this.LazyLoad();
      this.Id((Expression<Func<ProcessorCommands, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.Map((Expression<Func<ProcessorCommands, object>>) (x => x.Token)).Column("token");
      this.Map((Expression<Func<ProcessorCommands, object>>) (x => x.Opcode)).Column("opcode");
      this.Map((Expression<Func<ProcessorCommands, object>>) (x => x.Param)).Column("param");
    }
  }
}
