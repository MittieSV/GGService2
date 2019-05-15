namespace GGService2.DAL.Model
{
  public class Balance
  {
    public virtual int Id { get; set; }

    public virtual string Owner { get; set; }

    public virtual double BalanceVal { get; set; }
  }
}
