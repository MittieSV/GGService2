using GGService2.DAL.Classes.Enums;

namespace GGService2.DAL.Commands
{
  public class CommandResult
  {
    public ECommandStatus Status { get; set; }

    public string Description { get; set; }

    public string Token { get; set; }
  }
}
