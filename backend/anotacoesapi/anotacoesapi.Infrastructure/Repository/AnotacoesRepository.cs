using anotacoesapi.Infrastructure.Model;
using anotacoesapi.Infrastructure.Repository.Interface;
using anotacoesapi.Infrastructure.Repository.Scripts;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace anotacoesapi.Infrastructure.Repository
{
    public class AnotacoesRepository : IAnotacoesRepository
    {
        private IConfiguration _configuration;

        public AnotacoesRepository(IConfiguration config)
        {
            _configuration = config;
        }

        public async Task<int> Create(AnotacoesModel anotacoes)
        {
            using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.ExecuteAsync(AnotacoesScript.Create, anotacoes);
            }
        }

        public async Task<int> Delete(long id)
        {
            using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.ExecuteAsync(AnotacoesScript.Delete, id);
            }
        }

        public async Task<IEnumerable<AnotacoesModel>> GetAll()
        {
            using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return (List<AnotacoesModel>)await connection.QueryAsync<AnotacoesModel>(AnotacoesScript.GetAll);
            }
        }

        public async Task<int> Update(AnotacoesModel anotacoes)
        {
            using (var connection = new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")))
            {
                return await connection.ExecuteAsync(AnotacoesScript.Update, anotacoes);
            }
        }
    }
}
