using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParksApi.Models
{
  public class State
  {
    [Required]
    public int StateId { get; set; }
    [Required]
    public string Name { get; set; }
    public int NumberOfParks { get; set; }

    public virtual ICollection<Park> Parks { get; set; }

    public State()
    {
      this.Parks = new HashSet<Park>();
    }

  }
}