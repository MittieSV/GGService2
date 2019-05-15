namespace GGService2.DAL.Interfaces
{
  public interface ICache
  {
    void Set(string key, string value);

    string Get(string key);

    bool Get(string key, out string value);
  }
}
