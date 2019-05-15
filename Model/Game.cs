namespace GGService2.DAL.Model
{
  public class Game
  {
    public virtual int Id { get; set; }

    public virtual string Name { get; set; }

    public virtual string ShortName { get; set; }

    public virtual int Active { get; set; }

    public virtual string Module { get; set; }

    public virtual string ControllerPath { get; set; }

    public virtual int EloPercent { get; set; }

    public virtual int GiveUpMins { get; set; }
  }
}
