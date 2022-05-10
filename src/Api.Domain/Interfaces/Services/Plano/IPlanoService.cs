using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Plano
{
    public interface IPlanoService
    {
        Task<PlanosEntity> Get(Guid id);
        Task<IEnumerable<PlanosEntity>> GetOperadora(Guid operadora);
        Task<IEnumerable<PlanosEntity>> GetPlanoEsp(Guid planoesp);
        Task<IEnumerable<PlanosEntity>> GetTipo(Guid tipo);
        Task<IEnumerable<PlanosEntity>> GetAll();
        Task<PlanosEntity> Post(PlanosEntity planos);
        Task<PlanosEntity> Put(PlanosEntity planos);
        Task<bool> Delete(Guid id);

    }
}
