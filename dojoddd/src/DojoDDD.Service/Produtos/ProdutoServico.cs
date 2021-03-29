using DojoDDD.Domain.Interfaces;
using DojoDDD.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Service
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public async Task<Produto> ConsultarPorId(int id)
        {
            return await _produtoRepositorio.ConsultarPorId(id);
        }

        public async Task<IEnumerable<Produto>> ConsultarTodos()
        {
            return await _produtoRepositorio.ConsultarTodos();
        }
    }
}