namespace GGService2.DAL.Commands
{
  public class RegisterOnTournamentCommand : BaseCommand
  {
    public string TournamentHash { get; set; }

    public string GameAccountHash { get; set; }
  }
}
