using GGService2.DAL.Commands;
using System;
using System.Reactive.Subjects;

namespace GGService2.DAL.Interfaces
{
  public interface ICommandProvider
  {
    void RegisterMessageType<T>(Predicate<T> compare, Action<T> handler, bool willHandleResult);

    void ProcessRealCommmand(BaseCommand obj);

    Subject<BaseBattleCommand> OnBattleCommand { get; }

    void ReportError(BaseCommand command, Exception e);
  }
}
