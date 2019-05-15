namespace GGService2.DAL.Model
{
  public class GameAccountRandom : GameAccount
  {
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

    public override string GetIdentity()
    {
      return "";
    }
  }
}
