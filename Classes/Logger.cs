using GGService2.DAL.Classes.Enums;
using GGService2.DAL.Interfaces;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace GGService2.DAL.Classes
{
  public class Logger : ILogger
  {
    public void Log(ELogLevel level, string log, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null)
    {
      TimeSpan timeSpan;
      if (level == ELogLevel.Error)
      {
        timeSpan = DateTime.UtcNow - DateTime.MinValue;
        File.AppendAllText("log.txt", string.Format(timeSpan.TotalSeconds.ToString() + ":{0}:{1}", (object) level, (object) log) + Environment.NewLine);
      }
      timeSpan = DateTime.UtcNow - DateTime.MinValue;
      Console.WriteLine(string.Format(timeSpan.TotalSeconds.ToString() + ":{0}:{1}", (object) level, (object) log));
    }
  }
}
