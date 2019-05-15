using Newtonsoft.Json;

namespace GGService2.DAL.Model
{
  public class HungerGamesSeason
  {
    public virtual int Id { get; set; }

    public virtual string Hash { get; set; }

    [JsonIgnore]
    public virtual Game Game { get; set; }

    public virtual string Name { get; set; }

    public virtual string DefaultParameters { get; set; }

    public virtual int? Active { get; set; }

    public virtual double Price { get; set; }

    public virtual int LivesAmount { get; set; }
  }
}
