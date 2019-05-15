using FluentNHibernate.Mapping;
using System;
using System.Linq.Expressions;

namespace GGService2.DAL.Model
{
  public class UserMap : ClassMap<User>
  {
    public UserMap()
    {
      this.Table("user");
      this.LazyLoad();
      this.Id((Expression<Func<User, object>>) (x => (object) x.Id)).GeneratedBy.Identity().Column("id");
      this.Map((Expression<Func<User, object>>) (x => x.Hash)).Column("hash");
      this.Map((Expression<Func<User, object>>) (x => x.BonusHash)).Column("bonus_hash");
      this.Map((Expression<Func<User, object>>) (x => x.Username)).Column("username");
      this.Map((Expression<Func<User, object>>) (x => x.AuthKey)).Column("auth_key");
      this.Map((Expression<Func<User, object>>) (x => x.PasswordHash)).Column("password_hash");
      this.Map((Expression<Func<User, object>>) (x => x.ConfirmationHash)).Column("confirmation_hash");
      this.Map((Expression<Func<User, object>>) (x => x.PasswordResetToken)).Column("password_reset_token");
      this.Map((Expression<Func<User, object>>) (x => x.Email)).Column("email");
      this.Map((Expression<Func<User, object>>) (x => (object) x.Status)).Column("status");
      this.Map((Expression<Func<User, object>>) (x => (object) x.CreatedAt)).Column("created_at");
      this.Map((Expression<Func<User, object>>) (x => (object) x.UpdatedAt)).Column("updated_at");
      this.Map((Expression<Func<User, object>>) (x => (object) x.VisitedAt)).Column("visited_at");
      this.Map((Expression<Func<User, object>>) (x => x.Role)).Column("role");
      this.Map((Expression<Func<User, object>>) (x => x.AdditionalIdentity)).Column("additional_identity");
      this.Map((Expression<Func<User, object>>) (x => x.FirstIp)).Column("first_ip");
      this.Map((Expression<Func<User, object>>) (x => (object) x.Balance)).Column("balance");
    }
  }
}
