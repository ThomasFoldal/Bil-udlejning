namespace Bil_udlejning
{
    public class Renting
    {
        public int Id { get; set; }
        public Car Car_id { get; set; }
        public bool GPS { get; set; }
        public bool Baby_chair { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public double price_sum { get; set; }
    }
}
