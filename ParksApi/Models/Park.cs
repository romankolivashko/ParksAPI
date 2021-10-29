using System.ComponentModel.DataAnnotations;

namespace ParksApi.Models
{
    public class Park
    {
        [Required]
        public int ParkId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string State { get; set; }
        public string StateId { get; set; }
        public string Area { get; set; }
        public int Visitors { get; set; }
        public int YearEstablished { get; set; }
    }
}