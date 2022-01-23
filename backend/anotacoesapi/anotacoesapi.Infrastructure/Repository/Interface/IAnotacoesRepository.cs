using anotacoesapi.Infrastructure.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace anotacoesapi.Infrastructure.Repository.Interface
{
    public interface IAnotacoesRepository
    {
        public Task<IEnumerable<AnotacoesModel>> GetAll();
        public Task<int> Create(AnotacoesModel anotacoes);
        public Task<int> Update(AnotacoesModel anotacoes);
        public Task<int> Delete(long id);
        //public Task<AnotacoesModel> GetById(long id);
    }
}
