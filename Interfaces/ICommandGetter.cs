using GGService2.DAL.Model;
using System.Collections.Generic;

namespace GGService2.DAL.Interfaces
{
  public interface ICommandGetter
  {
    List<ProcessorCommands> GetCommands();
  }
}
