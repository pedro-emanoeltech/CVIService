using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.Services
{
    public class ContaApp : ContaServiceApp
    {
        private readonly IServiceProvider _serviceProvider;
        public ContaApp(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider; 
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = _serviceProvider.CreateScope();
            var ContaService =  scope.ServiceProvider.GetRequiredService<IContaService>();
            var conta = await ContaService.AdicionarConta(cancellationToken);


        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected override Task ExecuteAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
