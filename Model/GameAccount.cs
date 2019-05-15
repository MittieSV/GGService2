using GGService2.DAL.Interfaces;
using Newtonsoft.Json;
using System.IO;

namespace GGService2.DAL.Model
{
  public class GameAccount : IIdentity
  {
    public virtual int Id { get; set; }

    public virtual Game Game { get; set; }

    public virtual string Hash { get; set; }

    public virtual string Preview { get; set; }

    public virtual string Owner { get; set; }

    public virtual string Avatar { get; set; }

    public virtual int Hidden { get; set; }

    protected string Serialize(object obj)
    {
      StringWriter stringWriter = new StringWriter();
      JsonSerializer.Create().Serialize((TextWriter) stringWriter, obj);
      return stringWriter.ToString();
    }

    [JsonIgnore]
    public virtual GameAccountCsgo AsCsgo
    {
      get
      {
        return this as GameAccountCsgo;
      }
    }

    [JsonIgnore]
    public virtual GameAccountLol AsLol
    {
      get
      {
        return this as GameAccountLol;
      }
    }

    [JsonIgnore]
    public virtual GameAccountRandom AsRandom
    {
      get
      {
        return this as GameAccountRandom;
      }
    }

    public virtual string GetIdentity()
    {
      return "";
    }
  }
}
