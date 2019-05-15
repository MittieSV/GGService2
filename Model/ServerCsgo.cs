using GGService2.DAL.Classes.Enums;

namespace GGService2.DAL.Model
{
  public class ServerCsgo
  {
    public virtual int Id { get; set; }

    public virtual Battle Battle { get; set; }

    public virtual string Address { get; set; }

    public virtual int? Port { get; set; }

    public virtual string RconPassword { get; set; }

    public virtual string SshUser { get; set; }

    public virtual string SshPassword { get; set; }

    public virtual EServerStatus Status { get; set; }
  }
}
