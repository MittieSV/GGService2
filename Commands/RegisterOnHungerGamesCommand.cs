namespace GGService2.DAL.Commands
{
  public class RegisterOnHungerGamesCommand : BaseCommand
  {
    public string GameAccountHash { get; set; }

    public int SeasonId { get; set; }
  }
}
