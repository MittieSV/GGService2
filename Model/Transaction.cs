namespace GGService2.DAL.Model
{
  public class Transaction
  {
    public virtual int Id { get; set; }

    public virtual string From { get; set; }

    public virtual string To { get; set; }

    public virtual double Amount { get; set; }
  }
}
