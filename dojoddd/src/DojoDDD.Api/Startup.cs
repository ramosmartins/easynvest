using DojoDDD.Domain.Interfaces;
using DojoDDD.Infra.Repository;
using DojoDDD.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DojoDDD.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();

            services.AddSingleton<DataStore>();
            services.AddTransient<IClienteRepositorio, ClienteRepositorio>();
            services.AddTransient<IProdutoRepositorio, ProdutoRepositorio>();
            services.AddTransient<IOrdemCompraRepositorio, OrdemCompraRepositorio>();

            services.AddTransient<IClienteServico, ClienteServico>();
            services.AddTransient<IProdutoServico, ProdutoServico>();
            services.AddTransient<IOrdemCompraServico, OrdemCompraServico>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
