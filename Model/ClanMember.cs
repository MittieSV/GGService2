namespace GGService2.DAL.Model
{
  public class ClanMember
  {
    public virtual int Id { get; set; }

    public virtual Clan Clan { get; set; }

    public virtual GameAccount GameAccount { get; set; }

    public virtual int? IsLeader { get; set; }

    public virtual int? Confirmed { get; set; }
  }
}
