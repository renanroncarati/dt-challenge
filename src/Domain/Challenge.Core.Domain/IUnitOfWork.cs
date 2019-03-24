using Challenge.Core.Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace Challenge.Core.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IVehicleSalesRepository VehicleSalesRepository { get; set; }

        //preferrable than Save
        Task CompleteAsync();
    }
}
