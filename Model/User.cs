namespace GGService2.DAL.Model
{
  public class User
  {
    public virtual int Id { get; set; }

    public virtual string Hash { get; set; }

    public virtual string BonusHash { get; set; }

    public virtual string Username { get; set; }

    public virtual string AuthKey { get; set; }

    public virtual string PasswordHash { get; set; }

    public virtual string ConfirmationHash { get; set; }

    public virtual string PasswordResetToken { get; set; }

    public virtual string Email { get; set; }

    public virtual int? Status { get; set; }

    public virtual int? CreatedAt { get; set; }

    public virtual int? UpdatedAt { get; set; }

    public virtual int? VisitedAt { get; set; }

    public virtual string Role { get; set; }

    public virtual string AdditionalIdentity { get; set; }

    public virtual string FirstIp { get; set; }

    public virtual float? Balance { get; set; }
  }
}
