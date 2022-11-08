using Microsoft.Extensions.DependencyInjection;
using SistemaCompra.Domain.ProdutoAggregate;
using SistemaCompra.Domain.SolicitacaoCompraAggregate;
using SistemaCompra.Infra.Data.Produto;
using SistemaCompra.Infra.Data.SolicitacaoCompra;
using SistemaCompra.Infra.Data.UoW;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCompra.Infra.Data.Configuracao
{
    public class DependencyInjection
    {
        public static IServiceCollection RegisterServices(IServiceCollection services)
        {
            //ConfigData
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Repository
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ISolicitacaoCompraRepository, SolicitacaoCompraRepository>();

            //Services

            return services;
        }
    }
}
