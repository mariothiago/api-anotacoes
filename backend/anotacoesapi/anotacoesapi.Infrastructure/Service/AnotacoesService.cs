using anotacoesapi.Infrastructure.Model;
using anotacoesapi.Infrastructure.Repository;
using anotacoesapi.Infrastructure.Service.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace anotacoesapi.Infrastructure.Service
{
    public class AnotacoesService : IAnotacoesService
    {
        private AnotacoesRepository _repository { get; set; }
        public AnotacoesService(IConfiguration config)
        {
            _repository = new AnotacoesRepository(config);
        }

        public async Task<long> Create(AnotacoesModel anotacoes)
        {
            return await _repository.Create(anotacoes);
        }

        public async Task<int> Delete(long id)
        {
            return await _repository.Delete(id);
        }

        public async Task<List<AnotacoesModel>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<int> Update(AnotacoesModel anotacoes)
        {
            return await _repository.Update(anotacoes);
        }

        public async Task<AnotacoesModel> GetById(long id)
        {
            return await _repository.GetById(id);
        }
    }
}
