using GGService2.DAL.Classes.Enums;
using System.Runtime.CompilerServices;

namespace GGService2.DAL.Interfaces
{
  public interface ILogger
  {
    void Log(ELogLevel level, string log, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null);
  }
}
