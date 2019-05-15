using GGService2.DAL.Model;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace GGService2.DAL.Classes
{
  public class EloManager
  {
    private readonly ISessionFactory _factory;
    private readonly Logger _logger;
    private const int MINIMUM_ELO = 100;

    public EloManager(ISessionFactory factory, Logger logger)
    {
      this._factory = factory;
      this._logger = logger;
    }

    public int Get(string hash)
    {
      using (ISession session = this._factory.OpenSession())
      {
        HungerGamesElo hungerGamesElo = session.Query<HungerGamesElo>().FirstOrDefault<HungerGamesElo>((Expression<Func<HungerGamesElo, bool>>) (x => x.Owner == hash));
        if (hungerGamesElo == null)
        {
          using (ITransaction transaction = session.BeginTransaction())
          {
            hungerGamesElo = new HungerGamesElo();
            hungerGamesElo.Owner = hash;
            hungerGamesElo.Elo = 100;
            session.Save((object) hungerGamesElo);
            transaction.Commit();
          }
        }
        return hungerGamesElo.Elo;
      }
    }

    public void Change(string hash, int eloScore)
    {
      using (ISession session = this._factory.OpenSession())
      {
        using (ITransaction transaction = session.BeginTransaction())
        {
          HungerGamesElo hungerGamesElo = session.Query<HungerGamesElo>().FirstOrDefault<HungerGamesElo>((Expression<Func<HungerGamesElo, bool>>) (x => x.Owner == hash));
          if (hungerGamesElo == null)
          {
            hungerGamesElo = new HungerGamesElo();
            hungerGamesElo.Owner = hash;
            hungerGamesElo.Elo = 100;
            session.Save((object) hungerGamesElo);
          }
          hungerGamesElo.Elo = Math.Max(hungerGamesElo.Elo + eloScore, 100);
          session.Save((object) hungerGamesElo);
          transaction.Commit();
        }
      }
    }
  }
}
