using Challenge.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Challenge.Core.Domain.Services.Interfaces
{
    public interface IVehicleSalesService
    {
        Task<IEnumerable<VehicleSale>> GetSoldVehiclesAsync();
    }
}
