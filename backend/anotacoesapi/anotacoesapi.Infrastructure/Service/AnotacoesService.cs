using anotacoesapi.Infrastructure.Model;
using anotacoesapi.Infrastructure.Repository;
using anotacoesapi.Infrastructure.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace anotacoesapi.Infrastructure.Service
{
    public class AnotacoesService : IAnotacoesService
    {
        private AnotacoesRepository _repository { get; set; }
        public AnotacoesService()
        {
            _repository = new AnotacoesRepository();
        }
        public async Task<long> Create(AnotacoesModel anotacoes)
        {
            return await _repository.Create(anotacoes);
        }

        public Task<int> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AnotacoesModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(AnotacoesModel anotacoes)
        {
            throw new NotImplementedException();
        }
    }
}
