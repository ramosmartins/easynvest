using DojoDDD.Domain.Models;
using System.Threading.Tasks;

namespace DojoDDD.Domain.Interfaces
{
    public interface IOrdemCompraRepositorio
    {
        Task<string> RegistrarOrdemCompra(OrdemCompra ordemCompra);
        Task<string> ConsultarPorId(string id);
        Task<bool> AlterarOrdemCompra(OrdemCompra ordemCompra);
        Task<bool> AlterarOrdemCompra(string ordemId, OrdemCompraStatus novoOrdemCompraStatus);
    }
}