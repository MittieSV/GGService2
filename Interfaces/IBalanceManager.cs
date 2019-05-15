using NHibernate;

namespace GGService2.DAL.Interfaces
{
  public interface IBalanceManager
  {
    double GetBalance(string fromHash, ISession session);

    void Transfer(string fromHash, string toHash, double amount);
  }
}
