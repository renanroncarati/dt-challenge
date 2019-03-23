using Challenge.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge.Core.Domain.Repositories
{
    public interface IVehicleSales : IRepository<VehicleSale>
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        #region Async Methods
        Task<TEntity> GetAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        #endregion
    }
}
