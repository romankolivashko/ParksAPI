using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParksApi.Models
{
  public class State
  {
    public State()
        {
            this.Parks = new HashSet<Park>();
            this.JoinEntities = new HashSet<ParkState>();
        } 

        public virtual ICollection<ParkState> JoinEntities { get; set; }

    [Required]
    public int StateId { get; set; }
    [Required]
    public string Name { get; set; }
    public int NumberOfParks { get; set; }

    public virtual ICollection<Park> Parks { get; set; }

  }
}