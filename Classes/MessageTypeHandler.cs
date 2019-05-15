using System;

namespace GGService2.DAL.Classes
{
  public class MessageTypeHandler
  {
    public Delegate Handler { get; set; }

    public Delegate Predicate { get; set; }

    public bool WillHandleResult { get; set; }
  }
}
