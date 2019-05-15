namespace GGService2.DAL.Model
{
  public class GameAccountLol : GameAccount
  {
    public virtual string Region { get; set; }

    public virtual string SummonerName { get; set; }

    public virtual long LolId { get; set; }

    public override string Preview
    {
      get
      {
        return this.Serialize((object) new
        {
          region = this.Region,
          name = this.SummonerName
        });
      }
    }

    public override string GetIdentity()
    {
      return this.Region;
    }
  }
}
