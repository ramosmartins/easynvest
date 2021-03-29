using System.Threading.Tasks;

namespace DojoDDD.Domain.Interfaces
{
    public interface IOrdemCompraServico
    {
        Task<string> ConsultarPorId(string id);
        Task<bool> AlterarStatudOrdemDeCompraParaEmAnalise(string ordemDeCompraId);
        Task<string> RegistrarOrdemCompra(string clienteId, int produtoId, int quantidadeCompra);
    }
}