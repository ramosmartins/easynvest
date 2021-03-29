using DojoDDD.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Domain.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<Cliente> ConsultarPorId(string id);
        Task<IEnumerable<Cliente>> ConsultarTodos();
    }
}