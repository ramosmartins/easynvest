using DojoDDD.Domain.Interfaces;
using DojoDDD.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Service
{
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public async Task<Cliente> ConsultarPorId(string id)
        {
            return await _clienteRepositorio.ConsultarPorId(id);
        }

        public async Task<IEnumerable<Cliente>> ConsultarTodos()
        {
            return await _clienteRepositorio.ConsultarTodos();
        }
    }
}