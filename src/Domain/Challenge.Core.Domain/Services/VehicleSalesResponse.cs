namespace Challenge.Core.Domain.Services
{
    public class VehicleSalesResponse
    {
        public int DealNumber { get; set; }
        public string CustomerName { get; set; }
        public string DealershipName { get; set; }
        public string Vehicle { get; set; }
        public decimal Price { get; set; }
        public string Date { get; set; }

    }
}
