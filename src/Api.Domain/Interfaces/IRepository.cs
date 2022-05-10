using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces
{
    public interface IRepository<T> where T : PlanosEntity
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);

        Task<bool> DeleteAsync(Guid id);
        Task<T> SelectAsync(Guid id);
        Task<IEnumerable<T>> SelectOpAsync(Guid operadora);
        Task<IEnumerable<T>> SelectTipAsync(Guid tipo);
        Task<IEnumerable<T>> SelectPlaAsync(Guid planoesp);
        Task<IEnumerable<T>> SelectAsync();

    }
}
