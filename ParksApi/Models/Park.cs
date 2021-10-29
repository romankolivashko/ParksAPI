namespace ParkApi.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public string StateId { get; set; }
        public string Area { get; set; }
        public string Visitors { get; set; }
        public string YearEstablished { get; set; }
    }
}