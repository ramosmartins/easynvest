using Bogus;
using DojoDDD.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace DojoDDD.Infra.Repository
{
    public class DataStore
    {
        public List<OrdemCompra> OrdensCompras { get; set; } = new List<OrdemCompra>();

        public List<Cliente> Clientes { get; set; }
        public List<Produto> Produtos { get; set; }

        public DataStore()
        {
            LoadFakeData();
        }

        private void LoadFakeData()
        {
            Clientes = new Faker<Cliente>()
                .RuleFor(s => s.Id, f => f.UniqueIndex.ToString())
                .RuleFor(s => s.Nome, f => f.Name.FullName())
                .RuleFor(s => s.Endereco, f => f.Address.FullAddress())
                .RuleFor(s => s.Saldo, f => f.Finance.Amount(100, 1000))
                .Generate(10)
                .ToList();

            Produtos = new Faker<Produto>()
                .RuleFor(s => s.Id, f => f.UniqueIndex)
                .RuleFor(s => s.Descricao, f => f.Commerce.ProductName())
                .RuleFor(s => s.Estoque, 1000)
                .RuleFor(s => s.ValorMinimoDeCompra, 500)
                .RuleFor(s => s.PrecoUnitario, f => f.Commerce.Price(1, 100, 2))
                .Generate(5)
                .ToList();

            OrdensCompras = new Faker<OrdemCompra>()
                .RuleFor(s => s.ClienteId, new Cliente().Id)
                .RuleFor(s => s.DataOperacao, f => f.Date.Past(1))
                .RuleFor(s => s.Id, f => f.UniqueIndex.ToString())
                .RuleFor(s => s.PrecoUnitario, f => f.Finance.Amount(10, 300))
                .RuleFor(s => s.ProdutoId, new Produto().Id)
                .RuleFor(s => s.QuantidadeSolicitada, f => f.Random.Int(1, 30))
                .RuleFor(s => s.Status, f => new OrdemCompraStatus())
                .RuleFor(s => s.ValorOperacao, f => f.Finance.Amount(10, 100000))
                .Generate(30)
                .ToList();
        }
    }
}