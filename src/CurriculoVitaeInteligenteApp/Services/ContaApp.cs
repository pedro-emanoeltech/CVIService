using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CurriculoVitaeInteligenteApp.Services
{
    public class ContaApp 
    {
        //private readonly IServiceProvider _serviceProvider;
        //protected readonly IMapper _mapper;

        //public ContaApp(IServiceProvider serviceProvider,IMapper mapper)
        //{
        //    _serviceProvider = serviceProvider; 
        //    _mapper = mapper;
        //}

        //public override async Task StartAsync(CancellationToken cancellationToken)
        //{
        //    using var scope = _serviceProvider.CreateScope();
        //    var ContaService =  scope.ServiceProvider.GetRequiredService<IContaService>();
        //    var conta = await ContaService.AdicionarConta(cancellationToken);


        //}

        //public override Task StopAsync(CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        //protected override Task ExecuteAsync(CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
