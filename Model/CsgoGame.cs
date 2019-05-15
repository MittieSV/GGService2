namespace GGService2.DAL.Model
{
  public class CsgoGame
  {
    public virtual int Id { get; set; }

    public virtual Battle Battle { get; set; }

    public virtual ServerCsgo ServerCsgo { get; set; }

    public virtual string Map { get; set; }

    public virtual int? ScoreLimit { get; set; }
  }
}
