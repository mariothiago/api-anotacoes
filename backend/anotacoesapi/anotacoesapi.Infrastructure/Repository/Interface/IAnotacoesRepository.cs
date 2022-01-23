using anotacoesapi.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace anotacoesapi.Infrastructure.Repository.Interface
{
    public interface IAnotacoesRepository
    {
        public Task<object> GetAll();
        public Task<int> Create(AnotacoesModel anotacoes);
        public Task<int> Update(AnotacoesModel anotacoes);
        public Task<int> Delete(long id);
    }
}
