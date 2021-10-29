namespace ParksApi.Models
{
  public class ParkState
  {       
    public int ParkStateId { get; set; }
    public int ParkId { get; set; }
    public int StateId { get; set; }
    public virtual Park Park { get; set; }
    public virtual State State { get; set; }
  }
}