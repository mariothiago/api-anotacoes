using anotacoesapi.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace anotacoesapi.Infrastructure.Service.Interface
{
    public interface IAnotacoesService
    {
        public Task<List<AnotacoesModel>> GetAll();
        public Task<long> Create(AnotacoesModel anotacoes);
        public Task<int> Update(AnotacoesModel anotacoes);
        public Task<int> Delete(long id);
        public Task<AnotacoesModel> GetById(long id);
    }
}
