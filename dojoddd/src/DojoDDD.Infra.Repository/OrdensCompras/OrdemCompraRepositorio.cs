﻿using DojoDDD.Domain.Interfaces;
using DojoDDD.Domain.Models;
using System;
using System.Threading.Tasks;

namespace DojoDDD.Infra.Repository
{
    public class OrdemCompraRepositorio : IOrdemCompraRepositorio
    {
        private readonly DataStore _dataStore;

        public OrdemCompraRepositorio(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<string> ConsultarPorId(string id)
        {
            var ordemCompra = await Task.FromResult(_dataStore.OrdensCompras.Find(x => x.Id.Equals(id, StringComparison.InvariantCultureIgnoreCase))).ConfigureAwait(false);
            return ordemCompra.Id;
        }

        public async Task<string> RegistrarOrdemCompra(OrdemCompra ordemCompra)
        {
            await Task.Run(() => _dataStore.OrdensCompras.Add(ordemCompra)).ConfigureAwait(false);
            return ordemCompra.Id;
        }

        public async Task<bool> AlterarOrdemCompra(OrdemCompra ordemCompra)
        {
            throw await Task.Run(() => new NotImplementedException());
        }

        public async Task<bool> AlterarOrdemCompra(string ordemId, OrdemCompraStatus novoOrdemCompraStatus)
        {
            throw await Task.Run(() => new NotImplementedException());
        }
    }
}