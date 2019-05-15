namespace GGService2.DAL.Model
{
  public class ProcessorCommands
  {
    public virtual int Id { get; set; }

    public virtual string Token { get; set; }

    public virtual string Opcode { get; set; }

    public virtual string Param { get; set; }
  }
}
