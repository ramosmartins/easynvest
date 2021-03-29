using DojoDDD.Domain.Interfaces;
using DojoDDD.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Infra.Repository
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly DataStore _dataStore;

        public ProdutoRepositorio(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<IEnumerable<Produto>> ConsultarTodos()
        {
            return await Task.FromResult(_dataStore.Produtos).ConfigureAwait(false);
        }

        public async Task<Produto> ConsultarPorId(int id)
        {
            return await Task.FromResult(_dataStore.Produtos.Find(x => x.Id.Equals(id))).ConfigureAwait(false);
        }
    }
}