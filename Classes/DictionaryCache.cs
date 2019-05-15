using GGService2.DAL.Interfaces;
using System.Collections.Concurrent;

namespace GGService2.DAL.Classes
{
  public class DictionaryCache : ICache
  {
    private readonly ConcurrentDictionary<string, string> _cache = new ConcurrentDictionary<string, string>();

    public void Set(string key, string value)
    {
      this._cache[key] = value;
    }

    public string Get(string key)
    {
      if (this._cache.ContainsKey(key))
        return this._cache[key];
      return (string) null;
    }

    public bool Get(string key, out string value)
    {
      if (this._cache.ContainsKey(key))
      {
        value = this._cache[key];
        return true;
      }
      value = (string) null;
      return false;
    }
  }
}
