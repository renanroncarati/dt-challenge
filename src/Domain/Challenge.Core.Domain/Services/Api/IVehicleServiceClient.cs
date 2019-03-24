using RestEase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Core.Domain.Services.Api
{
    [Header("Content-type", "application/json")]
    
    public interface IVehicleServiceClient
    {
        [Get("VehicleSales")]
        Task<ICollection<VehicleSalesResponse>> GetVehicleSales();
    }
}
