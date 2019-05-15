namespace GGService2.DAL.Commands
{
  public class AddAccountCommand : BaseCommand
  {
    public string GameShortName { get; set; }

    public string JsonParams { get; set; }

    public string Owner { get; set; }
  }
}
