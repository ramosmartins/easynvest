using DojoDDD.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Domain.Interfaces
{
    public interface IProdutoRepositorio
    {
        Task<Produto> ConsultarPorId(int id);
        Task<IEnumerable<Produto>> ConsultarTodos();
    }
}