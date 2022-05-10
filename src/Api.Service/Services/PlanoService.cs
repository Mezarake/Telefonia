using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Plano;

namespace Api.Service.Services
{

    public class PlanoService : IPlanoService
    {

        private IRepository<PlanosEntity> _repository;
        public PlanoService(IRepository<PlanosEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<PlanosEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<PlanosEntity>> GetOperadora(Guid operadora)
        {
            return await _repository.SelectOpAsync(operadora);
        }

        public async Task<IEnumerable<PlanosEntity>> GetTipo(Guid tipo)
        {
            return await _repository.SelectTipAsync(tipo);
        }

        public async Task<IEnumerable<PlanosEntity>> GetPlanoEsp(Guid planoesp)
        {
            return await _repository.SelectPlaAsync(planoesp);
        }

        public async Task<IEnumerable<PlanosEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<PlanosEntity> Post(PlanosEntity planos)
        {
            return await _repository.InsertAsync(planos);
        }

        public async Task<PlanosEntity> Put(PlanosEntity planos)
        {
            return await _repository.UpdateAsync(planos);
        }
    }
}
