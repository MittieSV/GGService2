using GGService2.DAL.Classes.Enums;

namespace GGService2.DAL.Model
{
  public class HungerGamesSession
  {
    public virtual int Id { get; set; }

    public virtual HungerGamesSeason HungerGamesSeason { get; set; }

    public virtual Battle Battle { get; set; }

    public virtual string Hash { get; set; }

    public virtual ESessionStatus Status { get; set; }

    public virtual string ActorPath { get; set; }
  }
}
