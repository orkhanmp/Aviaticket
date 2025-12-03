namespace AviaticketManagment.Models
{
    public class Ticket
    {
        public string Type { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime FlightDate { get; set; }
        public decimal Price { get; set; }
        public int BaggageKg { get; set; }
        public bool Meal { get; set; }
        public bool SeatSelection { get; set; }
        public bool Wifi { get; set; }
        public bool FastCheckIn { get; set; }
    }
}
