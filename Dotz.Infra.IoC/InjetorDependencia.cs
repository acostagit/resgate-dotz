using Dotz.Application.Interfaces;
using Dotz.Application.Services;
using Dotz.Domain.Interfaces;
using Dotz.Domain.Services;
using Dotz.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Dotz.Infra.IoC
{
    public class InjetorDependencia
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
            svcCollection.AddScoped<IProdutoApp, ProdutoApp>();
            svcCollection.AddScoped<IPedidoApp, PedidoApp>();
            svcCollection.AddScoped<IProdutoApp, ProdutoApp>();


            //Domínio
            svcCollection.AddScoped(typeof(IRepositoryBase<>), typeof(ServicoBase<>));
            //svcCollection.AddScoped<IProdutoSe, PratoServico>();

            //Repositorio
            svcCollection.AddScoped(typeof(IRepositoryBase<>), typeof(ServicoBase<>));
            svcCollection.AddScoped<IProdutoRepository, ProdutoRepository>();
            svcCollection.AddScoped<IPedidoRepository, PedidoRepository>();
            svcCollection.AddScoped<IContaRepository, ContaRepository>();
        }
    }
}
