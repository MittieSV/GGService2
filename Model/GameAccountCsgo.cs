namespace GGService2.DAL.Model
{
  public class GameAccountCsgo : GameAccount
  {
    public virtual long SteamId { get; set; }

    public virtual long AccountId { get; set; }

    public virtual string Name { get; set; }

    public override string Preview
    {
      get
      {
        return this.Serialize((object) new
        {
          name = this.Name
        });
      }
    }
  }
}
