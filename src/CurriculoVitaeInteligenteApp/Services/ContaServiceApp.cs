using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.Services
{
    public abstract class ContaServiceApp : IHostedService
    {
        protected ContaServiceApp()
        {

        }

        public abstract Task StartAsync(CancellationToken cancellationToken);
        public abstract Task StopAsync(CancellationToken cancellationToken);
        protected abstract Task ExecuteAsync(CancellationToken stoppingToken);
    }
}
