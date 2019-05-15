using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class NotificationMap : ClassMap<Notification>
  {
    public NotificationMap()
    {
      this.Table("Notification");
      this.LazyLoad();
      this.Id((Expression<Func<Notification, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.Map((Expression<Func<Notification, object>>) (x => x.Hash)).Column("hash");
      this.Map((Expression<Func<Notification, object>>) (x => x.Owner)).Column("owner");
      this.Map((Expression<Func<Notification, object>>) (x => x.Params)).Column("params");
      this.Map((Expression<Func<Notification, object>>) (x => (object) x.CreatedAt)).Column("created_at");
      this.Map((Expression<Func<Notification, object>>) (x => x.Message)).Column("message");
      this.Map((Expression<Func<Notification, object>>) (x => x.Class)).Column("class");
      this.Map((Expression<Func<Notification, object>>) (x => (object) x.Type)).Column("type");
      this.Map((Expression<Func<Notification, object>>) (x => (object) x.Buttons)).Column("buttons");
      this.Map((Expression<Func<Notification, object>>) (x => (object) x.IsRead)).Column("is_read");
      this.Map((Expression<Func<Notification, object>>) (x => (object) x.Answer)).Column("answer");
    }
  }
}
