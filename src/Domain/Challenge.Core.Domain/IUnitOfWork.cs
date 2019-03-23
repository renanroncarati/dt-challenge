using Challenge.Core.Domain.Repositories;
using System;

namespace Challenge.Core.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IVehicleSalesRepository VehicleSalesRepository { get; set; }

        //preferrable than Save
        int Complete();
    }
}
