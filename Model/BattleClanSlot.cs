using GGService2.DAL.Classes.Enums;

namespace GGService2.DAL.Model
{
  public class BattleClanSlot
  {
    public virtual int Id { get; set; }

    public virtual Clan Clan { get; set; }

    public virtual Battle Battle { get; set; }

    public virtual int Side { get; set; }

    public virtual EMemberState State { get; set; }
  }
}
