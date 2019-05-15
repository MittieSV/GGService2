using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class EventMap : ClassMap<Event>
  {
    public EventMap()
    {
      this.Table("Event");
      this.LazyLoad();
      this.Id((Expression<Func<Event, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.Map((Expression<Func<Event, object>>) (x => x.Subscriber)).Column("subscriber");
      this.Map((Expression<Func<Event, object>>) (x => x.Raiser)).Column("raiser");
      this.Map((Expression<Func<Event, object>>) (x => x.Name)).Column("name");
      this.Map((Expression<Func<Event, object>>) (x => x.Method)).Column("method");
    }
  }
}
