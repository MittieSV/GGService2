using GGService2.DAL.Classes.Enums;
using GGService2.DAL.Interfaces;
using Newtonsoft.Json;

namespace GGService2.DAL.Model
{
  public class HungerGamesRegistration : IHashable, IIdentity
  {
    private EHungerGamesRegistrationState _status;

    public virtual int Id { get; set; }

    [JsonIgnore]
    public virtual HungerGamesSeason HungerGamesSeason { get; set; }

    [JsonIgnore]
    public virtual GameAccount GameAccount { get; set; }

    public virtual string Hash { get; set; }

    public virtual int? CreatedAt { get; set; }

    public virtual EHungerGamesRegistrationState Status
    {
      get
      {
        return this._status;
      }
      set
      {
        this._status = value;
      }
    }

    public virtual int? StatusChangedAt { get; set; }

    public virtual string Owner { get; set; }

    public virtual string GetIdentity()
    {
      return this.GameAccount.GetIdentity();
    }
  }
}
