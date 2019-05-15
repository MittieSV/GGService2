using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class ChatMap : ClassMap<Chat>
  {
    public ChatMap()
    {
      this.Table("Chat");
      this.LazyLoad();
      this.Id((Expression<Func<Chat, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.Map((Expression<Func<Chat, object>>) (x => x.Hash)).Column("hash");
      this.Map((Expression<Func<Chat, object>>) (x => x.From)).Column("`from`");
      this.Map((Expression<Func<Chat, object>>) (x => x.To)).Column("`to`");
      this.Map((Expression<Func<Chat, object>>) (x => (object) x.CreatedAt)).Column("created_at");
      this.Map((Expression<Func<Chat, object>>) (x => (object) x.IsPublic)).Column("is_public");
      this.Map((Expression<Func<Chat, object>>) (x => x.Message)).Column("message");
      this.Map((Expression<Func<Chat, object>>) (x => (object) x.IsRead)).Column("is_read");
      this.Map((Expression<Func<Chat, object>>) (x => (object) x.IsSystem)).Column("is_system");
    }
  }
}
