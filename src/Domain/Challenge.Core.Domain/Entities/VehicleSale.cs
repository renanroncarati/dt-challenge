using System;

namespace Challenge.Core.Domain.Entities
{
    public class VehicleSale
    {
        public int DealNumber { get; set; }
        public string CustomerName { get; set; }
        public string DealershipName { get; set; }
        public string Vehicle { get; set; }
        public decimal Price { get; set; }
        public string Date { get; set; }
    }
}
