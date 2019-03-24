using Challenge.Core.Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace Challenge.Core.Domain
{
    /// <summary>
    /// this was built in case of need to access a database, just to share knowledge
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IVehicleSalesRepository VehicleSalesRepository { get; set; }

        //preferrable than Save
        Task CompleteAsync();
    }
}
